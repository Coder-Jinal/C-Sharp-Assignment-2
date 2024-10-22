using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J3 : Controller
    {
        /// <summary>
        /// Link: https://cemc.uwaterloo.ca/sites/default/files/documents/2018/2018CCCJrProblemSet.html
        /// You decide to go for a very long drive on a very straight road. Along this road are five cities. As you travel, you record the distance between each pair of consecutive cities.
        /// You would like to calculate a distance table that indicates the distance between any two of the cities you have encountered.
        /// </summary>
        /// <param name="dis1">the distance encountered between city 1 and city 2</param>
        /// <param name="dis2">the distance encountered between city 2 and city 3</param>
        /// <param name="dis3">the distance encountered between city 3 and city 4</param>
        /// <param name="dis4">the distance encountered between city 4 and city 5</param>
        /// <returns>It will return a distance table</returns>
        /// <example>
        /// GET: "https://localhost:7049/api/J3/calculateddistance?dis1=3&dis2=10&dis3=12&dis4=5" 
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// </example>
        [HttpGet(template:"calculateddistance")]
        public IActionResult calculateddistance(int dis1, int dis2, int dis3, int dis4 )
        {
            int[] distance = new int[5];
            distance[0] = 0;
            distance[1] = dis1;
            distance[2] = dis1+dis2;
            distance[3] = dis1+dis2+dis3;
            distance[4] = dis1+dis2+dis3+dis4;

            string totaldistance = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int distances = Math.Abs(distance[j] - distance[i]);
                    totaldistance = totaldistance + distances + " ";
                }
                totaldistance = totaldistance+"\n";
            }
            return Ok(totaldistance);
        }
    }
}
