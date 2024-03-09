using Microsoft.AspNetCore.WebUtilities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext ctx) => 
{
    ctx.Response.Headers.ContentType = "text/plain";
    try { 
        var queryStrings =  QueryHelpers.ParseQuery(ctx.Request.QueryString.Value);

        string operatorInput = queryStrings["operator"][0] ?? "";
        string firstNumberInput = queryStrings["firstNumber"][0] ?? "";
        string secondNumberInput = queryStrings["secondNumber"][0] ?? "";
                
        int firstNumber = int.Parse(firstNumberInput);
        int secondNumber = int.Parse(secondNumberInput);

        Operator operator_ = OperatorFactory.makeOperator(operatorInput);
        int output = operator_.Operate(firstNumber, secondNumber);

        ctx.Response.StatusCode = 200;

        await ctx.Response.WriteAsync(output.ToString());
        await ctx.Response.WriteAsync("\n");
    } catch (Exception e) { 
        ctx.Response.StatusCode = 400;
        await ctx.Response.WriteAsync(e.Message);
    }   
});

app.Run();
