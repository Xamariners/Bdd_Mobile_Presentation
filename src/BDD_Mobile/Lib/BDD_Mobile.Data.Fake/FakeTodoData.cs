using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Shared.Enums;
using BDDMobile.Shared.Models;

namespace BDDMobile.Data.Fake
{
    /// <summary>
    ///     Holds the fake data
    /// </summary>
    public static class FakeTodoData
    {
        private static List<TodoItem> _fakeData;
        /// <summary>
        ///     Gets the fake data.
        /// </summary>
        /// <value>The data.</value>
        public static List<TodoItem> FakeData
        {
            get
            {
                if (_fakeData == null)
                {
                    _fakeData = new List<TodoItem>()
                {

                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Read book for 15 minutes",
                        Details = "I want to start reading Gabriel Garcia Marquez",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Finish organizing craft cabinet",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-29),
                        Name = "Talk to Mom",
                        Details = "About new house",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-45),
                        Name = "Finish one load of laundry",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Fix desk",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-27),
                        Name = "Spend time as a family – picnic",
                        Details = "Maybe in the north of the town",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Collate receipts to update April’s budget",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Work on e-book",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-39),
                        Name = "Write two blog posts",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-29),
                        Name = "Make grocery list",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-17),
                        Name = "Wake up early",
                        Details =
                            "I am a big fan of waking at 5am and spending time working on myself before going to work.",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-36),
                        Name = "Exercise",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Rewrite goals",
                        Details = "About life",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Read motivational material",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Write a “To Do” List",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-22),
                        Name = "Check the News Headlines",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Write a blog about food",
                        Details = "Spicy food mainly",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Take time to look good",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-31),
                        Name = "Go to bed at a reasonable time",
                        Details = "Maximum at 1am",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-41),
                        Name = "Write a book about travelling in India",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-46),
                        Name = "Go to the gym 3 times a week",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-42),
                        Name = "Run a marathon",
                        Details = "First is in Madrid",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-23),
                        Name = "Travel to Colombia",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-23),
                        Name = "Cook for the children",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Buy a new guitar",
                        Details = "Get a Fender",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-32),
                        Name = "Buy a new car",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-19),
                        Name = "Get a new job",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-32),
                        Name = "Pay the electricity bills ",
                        Details = "200$",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-23),
                        Name = "Sell my house",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-41),
                        Name = "Rent an office",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-19),
                        Name = "Walk around the lake",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-14),
                        Name = "Visit my relatives in Scotland",
                        Details = "Summer time",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Buy Swiss chocolate",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-13),
                        Name = "Tidy my room",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-25),
                        Name = "Clean the fridge",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-25),
                        Name = "Repair the kitchen door",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Prepare my speech for my brother's weeding",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Travel to Sweden",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-36),
                        Name = "Prepare my Chinese exam",
                        Details = "Advanced level",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Study Portuguese",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-21),
                        Name = "Download new app for chatting",
                        Details = "WeChat",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-22),
                        Name = "Paint my house",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Plan the next two years of investment",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Plan to have children",
                        Details = "Maybe two, a boy and a girl",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Go to the waterpark with the family",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-27),
                        Name = "Go to New York on a business trip",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-47),
                        Name = "Attend to Jaime's party ",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-12),
                        Name = "Think carefully about moving abroad",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-43),
                        Name = "Getting a diploma in Business Administration",
                        Details = "I plan to go to study to Barcelona",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-48),
                        Name = "Get my nails done",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Visit Hawaii for a few days",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-14),
                        Name = "Buy candies for my niece",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Get a ticket for the next week of Bruno Mars",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-49),
                        Name = "Top up my subway card",
                        Details = "20$",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-28),
                        Name = "Sell my old phone",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Buy coffee",
                        Details = "Italian coffee",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-35),
                        Name = "Visit mom and dad",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-11),
                        Name = "Drink 2 litres of water a day",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Buy a keyboard",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Go to the Museum of Modern Art",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-10),
                        Name = "Find my friend house keys",
                        Details = "They should be somewhere in my room",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-48),
                        Name = "Set up a company in Luxembourg",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Fix TV antenna",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Go out with Mark next week",
                        Details = "Take him to the opera",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-40),
                        Name = "Record a video of myself surfing",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-16),
                        Name = "Learn how to make my own beer",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-37),
                        Name = "Go for a walk with Tracy",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Get healthy food for my cat",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-45),
                        Name = "Sell my camera",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-39),
                        Name = "Go for a picnic to the river",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Call to my Internet Provider",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-11),
                        Name = "Take the garbage out",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-48),
                        Name = "Find an USB cable for my phone",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-16),
                        Name = "Get a flight to Bahamas",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-26),
                        Name = "Leave the house in perfect conditions",
                        Details = "It as to be cleaned by the 15th of this month",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Find a boyfriend",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-46),
                        Name = "Feed my dog",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-22),
                        Name = "Eat as much pasta as I can",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Buy a ring to Mary",
                        Details = "A diamond one",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Get some fresh flowers",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Read a book in the park",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-36),
                        Name = "Listen to the latest Foo Fighters album",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-19),
                        Name = "Ride my bike to the office every morning",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-37),
                        Name = "Play my new brand videogame with friends",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-49),
                        Name = "Send an email to Charles",
                        Details = "I need to remember him I will go to the club on Sunday",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-42),
                        Name = "Get a pair of shoes",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-13),
                        Name = "Travel around Spain",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Arrange a football match at the office",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Play tennis with dad",
                        Details = "",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-40),
                        Name = "Go out to Eduard's bar",
                        Details = "",
                        TodoStatus = TodoStatus.InProgress
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Leave a good tip to the restaurant manager",
                        Details = "Around 10$",
                        TodoStatus = TodoStatus.Open
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-12),
                        Name = "Get some medicines for my back pain",
                        Details = "",
                        TodoStatus = TodoStatus.Closed
                    },
                    new TodoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Visit my grandmother",
                        Details = "Some time around May",
                        TodoStatus = TodoStatus.InProgress
                    },
                };
                }

                return _fakeData;
            }

            set
            {
                _fakeData = value;
            }
        }
    }
}