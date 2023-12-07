using Adapter;

Console.WriteLine( "Two versions of the Adapter Structural Design Pattern implementation\n" );
Console.WriteLine();


// First, the object Adapter variant
var legacyObject = new LegacyClass( );
var objectAdapterClient = new Client(new LoginAdapterObject(legacyObject));
objectAdapterClient.PerformLogin();

Console.WriteLine( );

// Second, the class adapter variant
var classAdapterClient = new Client(new LoginAdapterClass());
classAdapterClient.PerformLogin();

