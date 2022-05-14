/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    //As the question pointed out, the class name should start with an uppercase
    //public class workflowHandler
    public class WorkFlowHandler
    {
        private bool DoWork(string A, string B)
        {
            //wrap everything in the try catch block to make sure that errors are caught and we can log the errors.
            try
            {
                //The "S" in the word Server in a connection string should be uppercase. The Server and the DB should 
                //be called different names. The variable name conn and the variable name comm are very similar so 
                //it would be best to change the names to easily identify which variable is which
                *//*var conn = new SqlConnection("server=SID;Initial Catalog=SID");*//*


                //I recently learned at my current job (due to best practive mistakes within one of our applications)
                ////that there is something called a data leak, Or connection leak,
                //and if you do not open the connection to the database correctly and something goes wrong between the time
                //that you open the connection and before you close the connection, that connection will stay open
                //until the DB decides "hey this connection has been open for way too long, let me kill it"
                //This is a problem when the method with a best practice mistake is constantly being used because
                //eventually you will reach your max pool size. This is why we have using statements
                //which kills an action if something goes wrong. This is especially important when opening a connection
                //or executing an action in regards to a DB (Reading/writing).
                using (var connection = new SqlConnection("Server=SID;Initial Catalog=ADiffernetDbName"))
                {

                    SqlCommand command = new SqlCommand("GetValue", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@search", SqlDbType.VarChar, 15).Value = A;

                    connection.Open();
                    //As I mentioned when executing an action with regards to the DB you would also want to use a 
                    //using statement incase this action fails.
                    using (var reader = command.ExecuteReader())
                    {
                        //using the var datatype is best as it is more dynamic
                        var result = reader.GetValue(0).ToString();
                        if (result != null)
                        {
                            // I am not to sure what the below code does. If I could give an educational guess I
                            // would say that this compares string B and the result that is returned from the DB
                            //And if it does match it returns true and, false if they don't match.

                            var service = new WebService.Service();
                            return service.Validate(B, result);
                        }
                        else
                        {
                            //Without adding this we are not guarenteed to return anything and the reason why I return
                            //false is because we cannot validate the results vs B.
                            return false;
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                //Ideally you'd want to write the error to a log file but for simplicity and due to not having
                //method ssetup to write logs I am simply just throwing the error here.
                throw exception;
            }
        }
    }
}
*/