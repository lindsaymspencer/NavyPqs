using NavyPqs.Models;
using System;
using System.Collections.Generic;
using System.Web;

[Serializable]
public sealed class SessionSingleton
{
    #region Singleton

    private const string SESSION_SINGLETON_NAME = "Singleton_502E69E5-668B-E011-951F-00155DF26207";

    private int nextId = 0;

    private SessionSingleton()
    {
        Officers.Add(new Officer
        {
            Id = GetNextOfficerId(),
            FirstName = "Lindsay",
            LastName = "Spencer",
            Rank = "LTJG"
        });
        Officers.Add(new Officer
        {
            Id = GetNextOfficerId(),
            LastName = "Moss",
            FirstName = "Christopher",
            Rank = "LT"
        });
    }

    public int GetNextOfficerId()
    {
        return nextId++;
    }

    public static SessionSingleton Current
    {
        get
        {
            if (HttpContext.Current.Session[SESSION_SINGLETON_NAME] == null)
            {
                HttpContext.Current.Session[SESSION_SINGLETON_NAME] = new SessionSingleton();
            }

            return HttpContext.Current.Session[SESSION_SINGLETON_NAME] as SessionSingleton;
        }
    }

    #endregion

    public List<Officer> Officers { get; set; } = new List<Officer>();
}