//Switch CASE PRACTICE

Console.WriteLine("What is your favorite elementary school subject?");

var favSubject = Console.ReadLine();

switch (favSubject.ToLower())
{ 
    case "math":
        Console.WriteLine("Nice! Math was fun! Only the real ones remember having RED notebooks for math.");
        break;
    case "history":
        Console.WriteLine("History? You don't hear that one often. Thaat's pretty cool. Thanksgiving season was always fun during history.");
        break;
    case "english":
    case "language arts":
    case "language":
        Console.WriteLine("Believe it or not, this was one of my favorites! I remember hating diagramming sentences, but it grew on me over time.");
        break;
    case "science":
        Console.WriteLine("The best part was the home experiments! I know everybody had to make a pet rock at some point! Class pets were the best too!");
        break;
    case "gym":
    case "pe":
    case "recess":
        Console.Write("So many good times here! We were some heathens! Kids are so funny. As soon as we stepped foot across the threshold to the playground, all you'd here is yelling and see kids ake off in every direction lol. We would be balls of pinned up energy.");
        break;
    default:
        Console.WriteLine("I am not sure we had that one. Let me think. Maybe we called it something else when I was in school.");
        return;
}