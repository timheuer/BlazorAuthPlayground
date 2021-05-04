using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    [Headers("Authorization: Bearer")]
    public interface IStravaApi
    {
        [Get("/clubs/{clubId}/activities?page=1&per_page=100")]
        Task<List<Activity>> GetClubActivities(string clubId);

        [Get("/athlete")]
        Task<DetailedAthlete> GetLoggedInAthlete();
    }

    public class Activity
    {
        public int resource_state { get; set; }
        public Athlete athlete { get; set; }
        public string name { get; set; }
        public float distance { get; set; }
        public int moving_time { get; set; }
        public int elapsed_time { get; set; }
        public float total_elevation_gain { get; set; }
        public string type { get; set; }
        public object workout_type { get; set; }
    }

    public class Athlete
    {
        public int resource_state { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }


    public class DetailedAthlete
    {
        public long id { get; set; }
        public string username { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int resource_state { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string sex { get; set; }
        public bool premium { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int badge_type_id { get; set; }
        public string profile_medium { get; set; }
        public string profile { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int follower_count { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int friend_count { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int mutual_friend_count { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int athlete_type { get; set; }
        public string date_preference { get; set; }
        public string measurement_preference { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public object ftp { get; set; }
        //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        //public int weight { get; set; }
    }

    public class Bike
    {
        public string id { get; set; }
        public bool primary { get; set; }
        public string name { get; set; }
        public int resource_state { get; set; }
        public int distance { get; set; }
    }

    public class Shoes
    {
        public string id { get; set; }
        public bool primary { get; set; }
        public string name { get; set; }
        public int resource_state { get; set; }
        public int distance { get; set; }
    }

}
