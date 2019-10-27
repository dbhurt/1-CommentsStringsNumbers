using System;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HEY, START HERE!

            You've made it this far.  From here on you I will communicate as much as I can through comments
            such as this.  There is alot of extra stuff in this code, but that will be explained later.

            Scroll on down and look for more comments for further instruction.

             */
             Console.WriteLine("LetsSeeSomething--------------------------");
            LetsSeeSomething();
            Console.WriteLine("MakeYourOwnComments--------------------------");
            MakeYourOwnComments();
            Console.WriteLine("Variables--------------------------");
            Variables();
            Console.WriteLine("MoreVariables--------------------------");
            MoreVariables();
            Console.WriteLine("ManipulatingNumbers--------------------------");
            ManipulatingNumbers();
            Console.WriteLine("ManipulatingStrings--------------------------");
            ManipulateStrings();
        }

        static void LetsSeeSomething()
        {
            /* Continue reading here:
                Let's let you play with some incredibly basic code so you can see something happen.
             */

            /* For now all you need to know about this is that Console.WriteLine is used to write something
            to the output window.  That something is what you see in the parenthesis and quotes.
            Know that this is a STATEMENT.  You are telling the computer what to do.  All statements have
            to end with the ';'  Without it, you will have a compiler error */

            //Go ahead and press F5, you should see the text below in the output window.
             Console.WriteLine("You should see me in the output window");
             Console.WriteLine("What you see in quotes here is called a STRING, I'll spare you the academic description.");
             Console.WriteLine("When you see or hear STRING, know that you are dealing with text.");
             Console.WriteLine("Here is some more...");             

             //Now, try it yourself, write some more strings to the output window using something similar


        }

        static void MakeYourOwnComments()
        {
            /*
                STOP HERE AND READ!

                What you are reading right here is called a block comment.  Comments in C# are lines of code
                that are ignored by the compiler.  They don't do anything.  They are purely for information.
                Like how I'm communicating with you now.
                
                There are a couple different types of comments, as mentioned this is a block comment, notice 
                the slash star and the star slash on either sides of this.  That's how you create a block comment.

                Everything between those will be a comment and ignored by the compiler
            */

            //This is another type of comment.  Notice the double slashes.  It only works for one line
            //You have to continue using a double slash at the beginning of a line if you want
            //the comment to keep wrapping, however, this is a great example of when you should
            //probably use a block comment like above.

            //Mess around here writing your own comments.

            //When ready, scroll down for more

            
            Console.WriteLine("This isn't a comment, but this line will be compiled and be output when this program is run.");
            Console.WriteLine("All the other comments will not be seen in the output window.");
        }

        static void Variables()
        {
            /* VARIABLES
                What you have done above is something executed by the computer and immediately forgotten.  Know that
                when this code is executed, it's loaded into memory, the computer runs your statements, each statement
                is executed and forgotten.  It's a sad world.

                Variables are how you store values during execution.  You are telling the computer to place a special
                thing in it's memory.
             */

            
             //Since we talked strings earlier...
             string myInMemoryString = "Whatever I want";
             //Above we gave a statement.  
             //"string" we are telling the computer we want to create a variable of type "string"
             //"myInMemoryString" is our variable's name, that's how we refer to it, it can be anything we want
             // NOTE: Variable names cannot be used more than once!
             // after we set that variable equal to a string that we choose and then terminate.
             // NOTE: this pattern is important
             // NOTE: because we specified this variable is a string, when we set it's value, we need quotes, remember
             //it's text and text needs quotes in C# if set explicitly... whatever moving on

             //Now we can reference that string using what we've done before, hit F5 and you will see that above
             Console.WriteLine("Here is that string variable:");
             Console.WriteLine(myInMemoryString);

             myInMemoryString = "We are now changing the variable's value.";
             myInMemoryString = "Since we are chaning it again, the previous value is gone";
             myInMemoryString = "This is the last thing we changed it to.";
             Console.WriteLine("After changing it, here is the newest value:");
             Console.WriteLine(myInMemoryString);

             /*
                Notice above in the Console.WriteLine we have now passed our variable to be output. 
                Also, you don't see all the times we changed the variable written to the output because we only
                gave the output command at certain points.  Know as the computer runs through our statements, it
                is changing our string's value based on what we told it, but we also only told it to output
                after certain ones.  Clear as mud?
              */

              /* Try it.
              After this block comment, create your own string variable and set it.  Heck make as many variables as
              you want, change their values and output them. Afterwards, sroll down for more.
               */

        }

        static void MoreVariables()
        {
            /*
            STOP HERE AND READ
            Above we dealt with strings, know that there are many different types of things that we can create
            variables with, I'll just throw a couple more at you
             */

            //int is an integer, a whole number
             int myIntegerVariable = 5;
             //double is a decimal number
             //NOTE: double isn't the only way to store a decimal, but I digress
             double myDoubleVariable = 5.5;
             //DateTime is a complex object with a load of date information, just know for now that we 
             //are currently setting equal to the current time
             DateTime myDateVariable = DateTime.Now;

             //Add output statements below to output the values of the above variables

        }

        static void ManipulatingNumbers()
        {
            /* STOP AND CONTINUE
                Let's play with changing numbers.  You can do what you think.
             */

             int myNumber = 1;
             //Addition --------------------------------------
             myNumber = myNumber + 1; //basically 1+1
             Console.WriteLine("after adding, myNumber is:");
             Console.WriteLine(myNumber);
             //-----------------------------------------------

             //Subtraction------------------------------------
             // we used (+) earlier to add, write a statement below to subtract from myNumber using (-)
             Console.WriteLine("after subtracting, myNumber is:");
             Console.WriteLine(myNumber);
             //-----------------------------------------------

             //Multiplication------------------------------------
             // we used (-) earlier to add, write a statement below to multiply from myNumber using (*)
             Console.WriteLine("after multiplying, myNumber is:");
             Console.WriteLine(myNumber);
             //-----------------------------------------------

             //Division---------------------------------------
             // we used (*) earlier to add, write a statement below to divide from myNumber using (/)
             // NOTE: we are using an integer, which is a whole number, if your division
             // results in a decimal value, .net will round the number, just FYI
             Console.WriteLine("after dividing, myNumber is:");
             Console.WriteLine(myNumber);
             //-----------------------------------------------

            

        }

        static void ManipulateStrings()
        {
            /*
            STOP AND CONTINUE READING
            Let's play with string manipulation.
             */
             string myString = "my string";

             //You can add strings... this is called concatenation.
             Console.WriteLine(myString + " here is another string");

             /* 
              string is a class within .net  Yes, it is "just" text, but being a class means
              that it's an object, it has properties and methods that you can execute against it.
              */

             //In this example, notice we take our variable, put a '.' and call Length
             //Length is a property of a string that we can access by using the dot.
             Console.WriteLine("Length of myString: " + myString.Length);

             //class methods are called the same way but need () afterwards because you are 
             //able to send parameters. Don't worry what that means for now.  For now, follow
             //what we did above for Length, except call ToLower() 
             // NOTE: Case matters!

             //Now do the same except with ToUpper()


             /*
             https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8

             Play around as much as you want, for more reading, here is the string class documents from
             microsoft.  It includes code samples.  THESE DOCUMENTS ARE YOUR FRIEND.
             On that note, GOOGLE IS YOUR BEST FRIEND.
              */
             
        }
    }
}
