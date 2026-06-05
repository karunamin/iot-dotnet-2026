using MySqlConnector;
using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace WpfTest
{
    public partial class MainWindow : Window
    {
        DatabaseHelper databaseHelper;

        public MainWindow()
        {
            InitializeComponent();

            databaseHelper = new DatabaseHelper();

            LoadComboBoxData();
            LoadData();
        }

        private void LoadComboBoxData()
        {
            string query =
                "SELECT div_code, div_name FROM division";

            CboDivCode.ItemsSource =
                databaseHelper.Select(query).DefaultView;

            CboDivCode.SelectedValuePath = "div_code";
            CboDivCode.DisplayMemberPath = "div_name";
        }

        private void LoadData()
        {
            string query =
                @"SELECT b.book_idx,
                         b.author,
                         b.div_code,
                         d.div_name,
                         b.book_name,
                         b.release_dt,
                         b.isbn,
                         b.price
                  FROM books b
                  JOIN division d
                    ON b.div_code = d.div_code
                  ORDER BY b.book_idx";

            GrdBooks.ItemsSource =
                databaseHelper.Select(query).DefaultView;
        }

        private void GrdBooks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (GrdBooks.SelectedItem is DataRowView row)
            {
                TxtBookIdx.Text = row["book_idx"].ToString();
                TxtAuthor.Text = row["author"].ToString();
                TxtBookName.Text = row["book_name"].ToString();
                TxtIsbn.Text = row["isbn"].ToString();
                TxtPrice.Text = row["price"].ToString();

                DtpReleaseDt.SelectedDate =
                    Convert.ToDateTime(row["release_dt"]);

                CboDivCode.SelectedValue =
                    row["div_code"].ToString();

                SbiResMsg.Text =
                    $"{TxtBookIdx.Text}번 도서 로드 완료";
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string author = TxtAuthor.Text.Trim();
                string bookName = TxtBookName.Text.Trim();
                string isbn = TxtIsbn.Text.Trim();
                string divCode = Convert.ToString(CboDivCode.SelectedValue);

                if (!int.TryParse(TxtPrice.Text, out int price))
                {
                    MessageBox.Show("가격은 숫자");
                    return;
                }

                if (DtpReleaseDt.SelectedDate == null)
                {
                    MessageBox.Show("날짜 선택");
                    return;
                }

                DateTime releaseDt =
                    DtpReleaseDt.SelectedDate.Value;

                if (string.IsNullOrEmpty(TxtBookIdx.Text))
                {
                    string insert =
                        @"INSERT INTO books
                        (author,div_code,book_name,
                         release_dt,isbn,price)
                        VALUES
                        (@author,@div_code,@book_name,
                         @release_dt,@isbn,@price)";

                    databaseHelper.Execute(
                        insert,
                        new MySqlParameter("@author", author),
                        new MySqlParameter("@div_code", divCode),
                        new MySqlParameter("@book_name", bookName),
                        new MySqlParameter("@release_dt", releaseDt),
                        new MySqlParameter("@isbn", isbn),
                        new MySqlParameter("@price", price));

                    SbiResMsg.Text = "신규 저장 완료";
                }
                else
                {
                    int bookIdx =
                        Convert.ToInt32(TxtBookIdx.Text);

                    string update =
                        $@"UPDATE books
                           SET author='{author}',
                               div_code='{divCode}',
                               book_name='{bookName}',
                               release_dt='{releaseDt:yyyy-MM-dd}',
                               isbn='{isbn}',
                               price={price}
                         WHERE book_idx={bookIdx}";

                    databaseHelper.Execute(update);

                    SbiResMsg.Text =
                        $"{bookIdx}번 수정 완료";
                }

                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBookIdx.Text))
                return;

            int bookIdx =
                Convert.ToInt32(TxtBookIdx.Text);

            string query =
                $"DELETE FROM books WHERE book_idx={bookIdx}";

            databaseHelper.Execute(query);

            LoadData();
            ClearInputs();

            SbiResMsg.Text =
                $"{bookIdx}번 삭제 완료";
        }

        private void ClearInputs()
        {
            TxtBookIdx.Text = "";
            TxtAuthor.Text = "";
            TxtBookName.Text = "";
            TxtIsbn.Text = "";
            TxtPrice.Text = "";
            CboDivCode.SelectedIndex = -1;
            DtpReleaseDt.SelectedDate = null;
        }
    }
}