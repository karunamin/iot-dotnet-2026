using BookRentalApi.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;

namespace BookRentalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly string connString;

        public BooksController(IConfiguration configuration)
        {
            connString = configuration.GetConnectionString("bookrentalconnection");
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            List<Book> books = new();

            using var conn = new MySqlConnection(connString);
            await conn.OpenAsync();

            string query = @"
                SELECT
                    book_idx,
                    author,
                    div_code,
                    book_name,
                    release_dt,
                    isbn,
                    price
                FROM books
                ORDER BY book_idx DESC";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Book book = new Book
                {
                    BookIdx = reader.GetInt32("book_idx"),
                    Author = reader.IsDBNull("author") ? null : reader.GetString("author"),
                    DivCode = reader.GetString("div_code"),
                    BookName = reader.IsDBNull("book_name") ? null : reader.GetString("book_name"),
                    ReleaseDt = reader.IsDBNull("release_dt") ? null : reader.GetDateTime("release_dt"),
                    Isbn = reader.IsDBNull("isbn") ? null : reader.GetString("isbn"),
                    Price = reader.IsDBNull("price") ? null : reader.GetDecimal("price")
                };

                books.Add(book);
            }

            return Ok(books);
        }
        // 도서 한 권 조회
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookAsync(int id)
        {
            using var conn = new MySqlConnection(connString);
            await conn.OpenAsync();

            string query = @"
                SELECT
                    book_idx,
                    author,
                    div_code,
                    book_name,
                    release_dt,
                    isbn,
                    price
                FROM books
                WHERE book_idx = @BookIdx";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BookIdx", id);

            using var reader = await cmd.ExecuteReaderAsync();

            if (!await reader.ReadAsync())
            {
                return NotFound($"도서번호 {id}를 찾을 수 없습니다.");
            }

            Book book = new Book
            {
                BookIdx = reader.GetInt32("book_idx"),
                Author = reader.IsDBNull("author") ? null : reader.GetString("author"),
                DivCode = reader.GetString("div_code"),
                BookName = reader.IsDBNull("book_name") ? null : reader.GetString("book_name"),
                ReleaseDt = reader.IsDBNull("release_dt") ? null : reader.GetDateTime("release_dt"),
                Isbn = reader.IsDBNull("isbn") ? null : reader.GetString("isbn"),
                Price = reader.IsDBNull("price") ? null : reader.GetDecimal("price")
            };

            return Ok(book);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            using var conn = new MySqlConnection(connString);
            await conn.OpenAsync();

            string query = @"
        INSERT INTO books
        (
            author,
            div_code,
            book_name,
            release_dt,
            isbn,
            price
        )
        VALUES
        (
            @Author,
            @DivCode,
            @BookName,
            @ReleaseDt,
            @Isbn,
            @Price
        );

        SELECT LAST_INSERT_ID();
        ";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@DivCode", book.DivCode);
            cmd.Parameters.AddWithValue("@BookName", book.BookName);
            cmd.Parameters.AddWithValue("@ReleaseDt", book.ReleaseDt);
            cmd.Parameters.AddWithValue("@Isbn", book.Isbn);
            cmd.Parameters.AddWithValue("@Price", book.Price);

            var newId = Convert.ToInt32(await cmd.ExecuteScalarAsync());

            book.BookIdx = newId;

            return Ok(book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            using var conn = new MySqlConnection(connString);
            await conn.OpenAsync();

            string query = @"
        UPDATE books
        SET
            author = @Author,
            div_code = @DivCode,
            book_name = @BookName,
            release_dt = @ReleaseDt,
            isbn = @Isbn,
            price = @Price
        WHERE book_idx = @BookIdx
        ";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@DivCode", book.DivCode);
            cmd.Parameters.AddWithValue("@BookName", book.BookName);
            cmd.Parameters.AddWithValue("@ReleaseDt", book.ReleaseDt);
            cmd.Parameters.AddWithValue("@Isbn", book.Isbn);
            cmd.Parameters.AddWithValue("@Price", book.Price);
            cmd.Parameters.AddWithValue("@BookIdx", id);

            int result = await cmd.ExecuteNonQueryAsync();

            if (result == 0)
            {
                return NotFound($"도서번호 {id}를 찾을 수 없습니다.");
            }

            book.BookIdx = id;

            return Ok(book);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            using var conn = new MySqlConnection(connString);
            await conn.OpenAsync();

            string query = @"
        DELETE FROM books
        WHERE book_idx = @BookIdx
        ";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BookIdx", id);

            int result = await cmd.ExecuteNonQueryAsync();

            if (result == 0)
            {
                return NotFound($"도서번호 {id}를 찾을 수 없습니다.");
            }

            return Ok($"도서번호 {id} 삭제 완료");
        }
    }
}