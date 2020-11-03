using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRMusicRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DRMusicRecordController : ControllerBase
    {

        public static List<Record> RecordList = new List<Record>
        {
            new Record("Baby", 200, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("One Time", 216, 2009, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("Favorite Girl", 257, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("Down To Earth", 246, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("Bigger", 298, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("One Less Lonely Girl", 229, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("First Dance", 222, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("Love Me", 192, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("Common Denominator", 249, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),
            new Record("Somebody to love", 221, 2010, "Schoolboy Records", "Justin Bieber", "My Worlds"),

            new Record("Señorita", 294, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Like I Love You", 284, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("(Oh No) What You Got", 296, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Take It from Here", 310, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Cry Me a River", 250, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Rock Your Body", 220, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Nothin' Else", 295, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Last Night", 190, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Still on My Brain", 245, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("(And She Said) Take Me Now", 0, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Right For Me", 230, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Let's Take A Ride", 232, 2002, "Jive Records", "Justin Timberlake", "Justified"),
            new Record("Never Again", 240, 2002, "Jive Records", "Justin Timberlake", "Justified"),


            new Record("Wanna Be Startin' Somethin'", 320, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("Baby Be Mine", 245, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("The Girl Is Mine", 230, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("Thriller", 200, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("Beat It", 391, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("Billie Jean", 123, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("Human Nature", 234, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("P.Y.T (Pretty Young Thing)", 0, 1982, "Epic Records", "Michael Jackson", "Thriller"),
            new Record("The Lady in My Life", 340, 1982, "Epic Records", "Michael Jackson", "Thriller")
        };
        // GET: api/<DRMusicRecordController>
        [HttpGet]
        public List<Record> Get()
        {
            return RecordList;
        }

        // GET api/<DRMusicRecordController>/5
        [HttpGet("{id}")]
        public Record Get(int id)
        {
            return RecordList.Find(x=>x.ID == id);
        }

        // POST api/<DRMusicRecordController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DRMusicRecordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DRMusicRecordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
