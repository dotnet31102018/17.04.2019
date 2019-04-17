            using (SqlConnection conn = new SqlConnection(@"Data Source=VS17-SQL2017\SQLEXPRESS;Initial Catalog=1404;Integrated Security=True"))
            {
                string query = "select NAME from Students";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Names_Students");
                comboBox1.DataSource = ds.Tables["Names_Students"];
                comboBox1.ValueMember = "Name";
            }
