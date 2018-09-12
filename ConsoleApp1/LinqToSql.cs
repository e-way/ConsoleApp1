using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ConsoleApp1
{
    public partial class LinqToSql : Form
    {
        public LinqToSql()
        {
            InitializeComponent();
        }

        private void txtLinqToSql_TextChanged(object sender, EventArgs e)
        {

        }

        [Table(Name = "Person.Person")]
        public class Contact
        {
            [Column]
            public string Title;
            [Column]
            public string FirstName;
            [Column]
            public string LastName;
        }

        private void LinqToSql_Load_1(object sender, EventArgs e)
        {
            // connection string

            string connString = @"server = DESKTOP-V4UNJHJ;integrated security = true;database = AdventureWorks2017";
            try
            {
                // Create data context
                DataContext db = new DataContext(connString);
                // Create typed table
                Table<Contact> contacts = db.GetTable<Contact>();
                // Query database
                var contactDetails =
                from c in contacts
                where c.Title == "Mr."
                orderby c.FirstName
                select c;
                // Display contact details
                foreach (var c in contactDetails)
                {
                    txtLinqToSql.AppendText(c.Title);
                    txtLinqToSql.AppendText("\t");
                    txtLinqToSql.AppendText(c.FirstName);
                    txtLinqToSql.AppendText("\t");
                    txtLinqToSql.AppendText(c.LastName);
                    txtLinqToSql.AppendText("\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
