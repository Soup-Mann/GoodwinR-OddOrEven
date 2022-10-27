//Reed Goodwin
//10-26-2022
//OddOrEven
//THis is a program to take an input and decide if its odd or even!
//Peer Review: By Kenneth Fujimura -- Program works as intended, and evaluates intergers as odd or even in an API format. Not a lot to say other than good job. All numbers evaluated the way they should.

using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_GreaterorLessThan.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("Greater/{number1}")]
    public string Oddity(string number1)
    {

        long validnum = 0;
        bool number2;
        number2 = Int64.TryParse(number1, out validnum);
        int convertNum1 = Convert.ToInt32(number1);

        //num = Convert.ToInt64(number1);

        if (convertNum1 % 2 == 0)
        {
            return "This number is even!";
        }
        else
        {
            return "This number is odd";
        }

    }
}