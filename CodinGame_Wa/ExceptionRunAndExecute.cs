using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class ExceptionRunAndExecute
    {
        public void Run(Service s, Connection c)
        {
            try
            {
                s.SetConnection(c);
                s.Execute();
                c.Commit();
            }
            catch (Exception err)
            {
                c.Rollback();
                throw err;
            }
            finally
            {
                c.Close();
            }
        }

        /// Definition of a service
        public interface Service
        {
            void Execute();
            void SetConnection(Connection c);
        }

        /// Definition of a connection
        public interface Connection
        {
            void Commit();
            void Rollback();
            void Close();
        }
    }
}
