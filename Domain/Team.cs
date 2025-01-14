using Newtonsoft.Json;
using System.Text.Json.Serialization;
using static BlazorGitHubPagesDemo.Domain.Team;

namespace BlazorGitHubPagesDemo.Domain
{

    public class Team
    {
        [JsonProperty("nameFull")]
        public string? Zapas { get; set; }

        private string? _id;

        [JsonProperty("id")]
        public string? Id
        {
            get { return "42/LMJPID" + _id + "sk"; }
            set { _id = value; }
        }

        [JsonProperty("eventTables")]
        public List<EventTable> EventTables { get; set; }
    }
    public class EventTable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("boxes")]
        public List<Box>? Boxes { get; set; }
    }
    public class Box
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("cells")]
        public List<Cell> Cells { get; set; }
    }

    public class Cell
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("odd")]
        public string Odd { get; set; }
    }

}

