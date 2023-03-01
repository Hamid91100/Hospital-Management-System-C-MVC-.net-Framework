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


public class Patient
{
    private int patId;
    private string patName;
    private string patAdd;
    private string patCon;
    private int patAge;
    private string gender;
    private string bloodGroup;
    private string majorDis;

    public int PatId
    {
        get { return patId; }
        set { patId = value; }
    }

    public string PatName
    {
        get { return patName; }
        set { patName = value; }
    }

    public string PatAdd
    {
        get { return patAdd; }
        set { patAdd = value; }
    }

    public string PatCon
    {
        get { return patCon; }
        set { patCon = value; }
    }

    public int PatAge
    {
        get { return patAge; }
        set { patAge = value; }
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public string BloodGroup
    {
        get { return bloodGroup; }
        set { bloodGroup = value; }
    }

    public string MajorDis
    {
        get { return majorDis; }
        set { majorDis = value; }
    }
}