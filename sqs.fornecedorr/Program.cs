using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
        var request = new ReceiveMessageRequest
        {
            QueueUrl = "https://sqs.sa-east-1.amazonaws.com/767398107071/filinha"
        };
        var response = await client.ReceiveMessageAsync(request);
    
    }
}
