public void CreateAndSaveSignature()
{
    // Your code to create the digital signature would go here

    // Once the signature is created, you would save it to a file
    File.WriteAllText("signature.txt", "Signature content");

    // Then, you can inform the user of the success
    Console.WriteLine("The digital signature was successfully created and saved in the signature.txt file");
}
