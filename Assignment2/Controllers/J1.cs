using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1 : Controller
    {
        /// <summary>
        /// Final score is calculated at end of the game of Deliv-e-droid
        /// </summary>
        /// <param name="collisions">The number of collisions against the obstacles</param>
        /// <param name="deliveries">Recieved, the number of deliveries</param>
        /// <returns>It will return the final score</returns>
        /// <example>
        /// POST: https://localhost:7049/api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: collisions=2&deliveries=5
        /// --> 730
        /// POST: https://localhost:7049/api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: collisions=10&deliveries=0
        /// --> -100
        /// POST: https://localhost:7049/api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: collisions=3&deliveries=2
        /// --> 70
        /// </example>
        [HttpPost(template: "Delivedroid")]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult Delivedroid ([FromForm]int collisions, [FromForm]int deliveries)

        {
            int sum = (deliveries * 50) - (collisions * 10);

            if (collisions < deliveries)
            {
                sum = sum+500;
            }
            return Ok(sum);
        }

        /// <summary>
        /// Barley the dog loves treats. At the end of the day he is either happy or sad depending on the number and size of treats he receives 
        /// throughout the day. The treats come in three sizes: small, medium, and large. His happiness score can be measured using the following 
        /// formula: 1*S+2*M+3*L where S is the number of small treats, M is the number of medium treats and L is the number of large treats. 
        /// If Barley’s happiness score is 10 or greater then he is happy. Otherwise, he is sad.Determine whether Barley is happy or sad at the end of the day.
        /// </summary>
        /// <param name="small">number of small treats recieved by barley</param>
        /// <param name="medium">number of medium treats recieved by barley</param>
        /// <param name="large">number of large treats recieved by barley</param>
        /// <returns>It returns "Happy" if barley's happiness is 10 or greater, else it will return "Sad"</returns>
        /// <example>
        /// POST: https://localhost:7049/api/J1/Barleytreats
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: small=3&medium=2&large=1
        /// --> Happy
        /// POST: https://localhost:7049/api/J1/Barleytreats
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: small=3&medium=1&large=0
        /// --> Sad
        /// </example>

        [HttpPost(template: "Barleytreats")]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult Barleytreats([FromForm]int small, [FromForm]int medium, [FromForm]int large)
        {
            int happiness = (1*small) + (2*medium) + (3*large);
            if (happiness >= 10)
            {
                return Ok("Happy");
            }
            else 
            {
                return Ok("Sad");
            }
        }

    }
}
