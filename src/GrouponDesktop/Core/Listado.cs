using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Core;
using System.Windows.Forms;

namespace GrouponDesktop.Core
{
    public class Listado
    {
        DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        DataGridView dataGridView;
        String query;

        public Listado(DataGridView dgv, String query)
        {
            this.dataGridView = dgv;
            this.query = query;
        }

        public void actualizar_datagridview()
        {
            SQLResponse r;
            r = dbManager.executeQuery(this.query);
            this.dataGridView.DataSource = r.result;
            return;
        }

    }
}
