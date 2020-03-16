using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace DataBusinessLayer
{
    public class DebtDb
    {
        private readonly string connectionString = DBConnect.Properties.Settings.Default.DebtBookCString;

        public Debtor GetDebtor(int ID)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Debtors WHERE DebtorId="+ID, sqlcon);
            Debtor debtor = null;

            try
            {
                sqlcon.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    debtor = new Debtor((string) reader["Name"], (int) reader["TotalDebt"], (int)reader["DebtorId"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return debtor;
        }

        public ICollection<Debtor> GetDebtors()
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Debtors", sqlcon);
            ObservableCollection<Debtor> debtors = new ObservableCollection<Debtor>();

            try
            {
                sqlcon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Debtor debtor = new Debtor((string)reader["Name"], (int)reader["TotalDebt"], (int)reader["DebtorId"]);
                    debtors.Add(debtor);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return debtors;
        }

        public ICollection<Debt> GetDebtsFor(int ID)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            ObservableCollection<Debt> debts = new ObservableCollection<Debt>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Debts WHERE DebtorID="+ID, sqlcon);

            try
            {
                sqlcon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Debt debt = new Debt((int) reader["DebtValue"], (DateTime) reader["Date"]);
                    debts.Add(debt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return debts;
        }

        public void AddNewDebtor(Debtor debtor, Debt debt)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            
            string debtorInsert = "INSERT INTO Debtors" + "(DebtorId, Name, TotalDebt)" + "VALUES" + 
                                  $"({debtor.Id}, '{debtor.Name}', {debtor.TotalDebt})";
            string debtInsert = "INSERT INTO Debts" +
                                "(DebtorId, Date, DebtValue)" +
                                "VALUES" + 
                                $"({debtor.Id}, '{debt.Date}', {debtor.TotalDebt})";

            try
            {
                sqlcon.Open();

                SqlCommand debtorInsertCommand = new SqlCommand(debtorInsert, sqlcon);
                SqlCommand debtInsertCommand = new SqlCommand(debtInsert, sqlcon);

                debtorInsertCommand.ExecuteNonQuery();
                debtInsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void AddNewDebtFor(Debtor debtor, Debt debt)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string debtInsert = "INSERT INTO Debts" +
                                "(DebtorId, Date, DebtValue)" +
                                "VALUES" +
                                $"({debtor.Id}, '{debt.Date}', {debtor.TotalDebt})";

            try
            {
                sqlcon.Open();

                SqlCommand debtInsertCommand = new SqlCommand(debtInsert, sqlcon);

                debtInsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

    }


}
