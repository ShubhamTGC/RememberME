using SimpleSQL;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserProfile 
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Username { get; set; }
    public string ImageUrl { get; set; }

   
}
