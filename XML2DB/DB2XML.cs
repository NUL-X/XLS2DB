using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML2DB
{
    class DB2XML
    {
        Connection con= new Connection();
        public DB2XML()
        {
           
        }

         public void TableToXML(string tbName)
        {
            con.TableToXml(tbName);

        }

        }
    }

   
