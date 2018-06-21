/***************************************************************
* Name: Zubaidah Alqaisi                                       *
* ZID: Z1786977                                                * 
* Course: CSCI 473 Section 2 Spring 2018                       *
* Assignment: Assign3                                          *
* Due Date: wednesday, Mar. 7.                                 *
* Program goal: Create tables in a database and perform some   *
*              queries. Using a database system called MariaDB,* 
*              a clone of MySQL.                               * 
***************************************************************/
using System;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Assign3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

/*******************************************************************
* Function: Quit_Click()                                           *
* Purpose: This function quits the entire form application.        *
* Arguments: none                                                  *
* Return: none (void)                                              *
********************************************************************/
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

/******************************************************************
* Function: Form1_Click()                                         *
* Purpose: This function handle MySql commands. It starts by      *
*          connecting to the database. Then it drops the          * 
*          tables to ensure that the tables do not exist in the   *
*          database. Then it will create the tables' schema.      *
*          It will then read from text files and insert the values*
*          in the tables. A list of tables in the database are    *  
*          displayed on the listbox for the user.                 *
* Argument: Object sender, EventArgs e                            *
* Return: none (void)                                             * 
* ****************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // connecting to the database server 
                using (MySqlConnection connection = new MySqlConnection("server=10.158.56.53;uid=csci473g01;pwd=wordpass01;database=csci473g01;"))
                {
                    MySqlCommand command;
                    connection.Open();             // open the connection

                    // drop the table classTable before creating a new one in case it exists in the database already
                    command = new MySqlCommand("drop table if exists ClassTable", connection);
                    command.ExecuteNonQuery();        // run the query

                    // creating the table schema of ClassTable 
                    command = new MySqlCommand("Create table ClassTable (Class varchar(20), Teacher varchar(20), Room int, Time char(5), Days char(5), Enrollment int, primary key(Class))", connection);
                    command.ExecuteNonQuery();

                    // using the StreamReader to read the file Class.txt and insert values into the ClassTable
                    using (StreamReader SR = new StreamReader("Class.txt"))
                    {
                        // ReadLine to read each line of data as a string.
                        String S = SR.ReadLine();

                        // checking for eof
                        while (S != null)
                        {
                            // the text file has a delimiter in it so split it before inserting the values 
                            String[] SArray = S.Split(',');  // Class.txt contains tab-delimited fields.

                            // insert the values from the text file into the ClassTable by concatenate strings to create the SQL string for the Insert command
                            String SqlString = "Insert Into ClassTable (Class, Teacher, Room, Time, Days, Enrollment) Values("+
                                                "'" + SArray[0] + "', '" + SArray[1] + "', '" + SArray[2] + "', '" + SArray[3] + "', '" + SArray[4] + "', '" + SArray[5] + "')";

                            
                        //    Output.Items.Add(SqlString);

                            // run the command using connection
                            MySqlCommand Command = new MySqlCommand(SqlString, connection);
                            Command.ExecuteNonQuery();

                            // second read
                            S = SR.ReadLine();

                        }// end of while

                    } // end of using for StreamReader

                    // drop the table RoomTable before creating a new one in case it exists in the database already
                    command = new MySqlCommand("drop table if exists RoomTable", connection);
                    command.ExecuteNonQuery();      // run the query 

                    // creating the table schema of RoomTable 
                    command = new MySqlCommand("Create table RoomTable (Room int, Capacity int, Smart char(1), primary key(Room))", connection);
                    command.ExecuteNonQuery();

                    // using the StreamReader to read the file Room.txt and insert values into the RoomTable
                    using (StreamReader SR = new StreamReader("Room.txt"))
                    {
                        // ReadLine to read each line of data as a string.
                        String S = SR.ReadLine();

                        // checking for eof
                        while (S != null)
                        {
                            // the text file has a delimiter in it so split it before inserting the values 
                            String[] SArray = S.Split(',');  // Room.txt contains tab-delimited fields.

                            // insert the values from the text file into the RoomTable by concatenate strings to create the SQL string for the Insert command
                            String SqlString = "Insert Into RoomTable (Room, Capacity, Smart) Values("+
                                                "'" + SArray[0] + "', '" + SArray[1] + "', '" + SArray[2] + "')";

                     //       Output.Items.Add(SqlString);

                            // run the command using connection
                            MySqlCommand Command = new MySqlCommand(SqlString, connection);
                            Command.ExecuteNonQuery();

                            // second read 
                            S = SR.ReadLine();

                        }// end of while

                    } // end of using for StreamReader

                    // drop the table OfficeTable before creating a new one in case it exists in the database already
                    command = new MySqlCommand("drop table if exists OfficeTable", connection);
                    command.ExecuteNonQuery();

                    // creating the table schema of OfficeTable 
                    command = new MySqlCommand("Create table OfficeTable (Teacher char(20), Office int, primary key(Teacher))", connection);
                    command.ExecuteNonQuery();

                    // using the StreamReader to read the file Office.txt and insert values into the OfficeTable
                    using (StreamReader SR = new StreamReader("Office.txt"))
                    {
                        // ReadLine to read each line of data as a string.
                        String S = SR.ReadLine();

                        // checking for eof
                        while (S != null)
                        {
                            // the text file has a delimiter in it so split it before inserting the values 
                            String[] SArray = S.Split(',');  // Office.txt contains tab-delimited fields.

                            // insert the values from the text file into the OfficeTable by concatenate strings to create the SQL string for the Insert command
                            String SqlString = "Insert Into OfficeTable (Teacher, Office) Values(" +
                                                "'" + SArray[0] + "', '" + SArray[1] + "')";

                     //       Output.Items.Add(SqlString);

                            // run the command using connection
                            MySqlCommand Command = new MySqlCommand(SqlString, connection);
                            Command.ExecuteNonQuery();

                            // second read 
                            S = SR.ReadLine();

                        }// end of while

                    } // end of using for StreamReader

                    // List the names of all tables in the database.
                     DataTable schema = connection.GetSchema("Tables");
                     Output.Items.Add("Tables presently in the database\n");
                     Output.Items.Add("---------------------------------\n\n");
                     foreach (DataRow row in schema.Rows)
                     {
                         Output.Items.Add(row[2].ToString());
                         Output.Items.Add("\n");
                     }

                     // if there is a connection then close it
                     if (connection != null)
                     {
                         connection.Close();
                     } // end of it 

                }//end use conn

            }// end of try block
            catch (MySqlException ex)
            {
                Output.Items.Add(ex.Message);
            } // end of catch

        } // end of Form_load

/******************************************************************
* Function: Excute_Click()                                       *
* Purpose: This function handel a few of MySql commands such as   *
*          insert, select, and select count. It will loop through *
*          the tables and prin the fields or print out a specific *
*           field based on the user's query.                      *
* Arguments: object sender, EventArgs e                           *
* Return: none (void)                                             *
* ****************************************************************/

        private void Excute_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            char[] space = {' ','('};
            string line;
            MySqlDataReader readLine;
            string name = " ";

            string query = mysqlCommand.Text;
            string[] arrayQuery = query.Split(space);

            // connecting to the database server 
            using (MySqlConnection connection = new MySqlConnection("server=10.158.56.53;uid=csci473g01;pwd=wordpass01;database=csci473g01;"))
            {
                try
                {
                    connection.Open();

                    //If the first part of the SQL command is "Select"
                    if (arrayQuery[0].ToLower() == "select")
                    {
                       // If the first part of the SQL command is "Select Count"
                        if (arrayQuery[1].ToLower() == "count")
                        {
                            // execute the query 
                            command = new MySqlCommand(query, connection);

                            //ExecuteScalar method to execute the SQL command and convert it to string then store it in line
                            line = command.ExecuteScalar().ToString();

                            // print the output to the list box
                            Output.Items.Add(line);
                            Output.Items.Add("\n");

                        } // end of inner if
                        else
                        {
                            // run the query 
                            command = new MySqlCommand(query, connection);

                            // ExecuteReader method to obtain the results of the query
                            readLine = command.ExecuteReader();
                            line = "";       // reset the line 

                            // loop through the fields of the table based on the fieldCount
                            for ( int i = 0; i < readLine.FieldCount; i++ )
                            {
                                // print output of each column'name' and each row of each column 'line'
                                name = readLine.GetName(i);
                                line += name.PadRight(10);                             // concatenate string

                            } // end of for 

                            Output.Items.Add(line);         // print the output to listbox
                            Output.Items.Add("\n");

                            // looping through the output 
                            while(readLine.Read())
                            {
                                line = String.Empty;          // reset line 

                                // loop through the fields of the table based on the fieldCount
                                for (int i = 0; i < readLine.FieldCount; i++)
                                {

                                    name = readLine.GetString(i);
                                    line += name.PadRight(10);

                                }  // end of for loop 

                                Output.Items.Add(line);     // print the output to listbox
                                Output.Items.Add("\n");
                              
                            } // end of while loop 

                        }// end  of else

                    } // end of outter if

                        // if the query starts with insert
                    else if (arrayQuery[0].ToLower() == "insert")
                    {
                        // run the query 
                        command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        // print the a message to the user to listbox
                        Output.Items.Add("The info has been added successfully");

                    }// end of else if
                    else
                    {
                        // any other sql command are not acceptable 
                        Output.Items.Add("Other SQL commands are not yet implemented.");

                    } // end of if

                } // end of try
                catch (MySqlException ex)
                {
                    Output.Items.Add(ex.Message);

                } // end of catch 

                // if there is a connection then close it
                if (connection != null)
                {

                    connection.Close();

                } // end of if 

            } // end of 2nd using 

        } // end of excute_Click() 

/******************************************************************* 
* Function: Clear_Click()                                          *
* Purpose: This function clears out the list box items, and the    *
*          MySql textbox once clicking on the 'clear all' button.  *        
* Arguments: none                                                  *
* Return: none (void)                                              *
********************************************************************/
        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Items.Clear();
            mysqlCommand.Clear();

        }// end of clear_Click () method

    }//end class

}//end namespace
