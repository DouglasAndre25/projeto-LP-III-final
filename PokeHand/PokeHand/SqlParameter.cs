using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeHand
{
    class SqlParameter
    {
        private string column;

        public string GetColumn()
        {
            return column;
        }

        public void SetColumn(string value)
        {
            column = value;
        }

        private System.Data.SqlDbType type;

        public System.Data.SqlDbType GetType()
        {
            return type;
        }

        public void SetType(System.Data.SqlDbType value)
        {
            type = value;
        }

        private object value;

        public object GetValue()
        {
            return value;
        }

        public void SetValue(object value)
        {
            this.value = value;
        }

        public SqlParameter(string column, System.Data.SqlDbType type, object value)
        {
            this.column = column;
            this.type = type;
            this.value = value;
        }
    }
}
