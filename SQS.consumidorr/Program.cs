
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using System.Collections;
using Amazon.SQS;
using Amazon;

Console.WriteLine("Hello, World!"); 
var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new SendMessageRequest
{
    QueueUrl = "https://sqs.sa-east-1.amazonaws.com/767398107071/filinha",
    MessageBody = "teste 123"
};

await client.SendMessageAsync( request );