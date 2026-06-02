Console.WriteLine("Hello, World!");
string name="Alice";
Console.WriteLine(name.ToUpper());

// 
// string region = null; //⚠Compiler warning CS8600
// Console.WriteLine(region.ToUpper()); //⚠Compiler warning CS8602


string? region = null;
// Null-conditional operator '?.' — skip the call if null
// If region is null, ToUpper() never executes. No crash.
string? upperRegion = region?.ToUpper();
Console.WriteLine($"Region (conditional): {upperRegion}");
// Null-coalescing operator '??' — provide a fallback value
// If region is null, use "Unassigned" instead.
string displayRegion = region ?? "Unassigned";
Console.WriteLine($"Region (coalesced): {displayRegion}");
// Null-coalescing assignment '??=' — assign only if currently null
// Useful for lazy initialization.
region ??= "Addis Ababa";
Console.WriteLine($"Region (assigned): {region}");


//  Declare Your First TMS Variables
string studentName = "Abeba";
string studentId = "STU-001";
int enrollmentCount = 3;
decimal grantAmount = 1999.99m; // 'm' suffix marks a decimal literal
DateTime enrolledAt = DateTime.UtcNow;
string? advisorName = null; // Optional field, can be null

Console.WriteLine();
Console.WriteLine("TMS Variables:");
Console.WriteLine($"Student Name: {studentName}");
Console.WriteLine($"Student ID: {studentId}");
Console.WriteLine($"Enrollment Count: {enrollmentCount}");
Console.WriteLine($"Grant Amount: {grantAmount:C}");
Console.WriteLine($"Enrolled At: {enrolledAt}");
Console.WriteLine($"Advisor Name: {advisorName ?? "Not assigned"}");