using Microsoft.AspNetCore.WebUtilities;

namespace Calculator
{ 
    class Program 
    {
        static void Main()
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();

            app.MapGet("/", async (HttpContext ctx) => 
            {
                try { 
                    var queryStrings = QueryHelpers.ParseQuery(ctx.Request.QueryString.Value);

                    IFactory Factory = new Factory();
                    IGetInput InputGetter = Factory.MakeInputGetter();

                    string operatorInput = InputGetter.Get(queryStrings, "operator");
                    string firstNumberInput = InputGetter.Get(queryStrings, "firstNumber");
                    string secondNumberInput = InputGetter.Get(queryStrings, "secondNumber");
                            
                    int firstNumber = int.Parse(firstNumberInput);
                    int secondNumber = int.Parse(secondNumberInput);

                    IOperator Operator = Factory.MakeOperator(operatorInput);

                    int output = Operator.Operate(firstNumber, secondNumber);

                    ctx.Response.StatusCode = 200;
                    ctx.Response.Headers.ContentType = "text/plain";

                    string response = string.Format($"The result of calculation is {output}");
                    await ctx.Response.WriteAsync(response);
                    await ctx.Response.WriteAsync("\n");
                } catch (Exception e) { 
                    ctx.Response.StatusCode = 400;
                    await ctx.Response.WriteAsync(e.Message);
                }   
            });

            app.Run();
        }
    }
}

