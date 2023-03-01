using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;


public class Doctor
{
    private int _docId;
    private string _docName;
    private string _docPass;
    private int _docExp;

    public int DocId
    {
        get { return _docId; }
        set { _docId = value; }
    }

    public string DocName
    {
        get { return _docName; }
        set { _docName = value; }
    }

    public string DocPass
    {
        get { return _docPass; }
        set { _docPass = value; }
    }

    public int DocExp
    {
        get { return _docExp; }
        set { _docExp = value; }
    }
}
