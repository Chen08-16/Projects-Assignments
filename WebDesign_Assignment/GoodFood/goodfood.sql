-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2022 at 07:51 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `goodfood`
--

-- --------------------------------------------------------

--
-- Table structure for table `article`
--

CREATE TABLE `article` (
  `id` int(11) NOT NULL,
  `image` varchar(255) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `author` varchar(255) NOT NULL,
  `c_description` text NOT NULL,
  `content` text DEFAULT NULL,
  `date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `article`
--

INSERT INTO `article` (`id`, `image`, `title`, `author`, `c_description`, `content`, `date`) VALUES
(1, 'Article1.jpeg', 'The 3 Best Gluten-Free Flours for Baking and Cooking', 'Beth Lipton', 'Calling all runners! Want to choose the best fuel for your performance? Here\'s a top five hit list.', 'Going gluten free is no longer just a trendy thing to do. With more awareness around gluten intolerance and celiac disease, adopting a gluten-free diet has become so widespread, most likely you or someone you know is doing it, has tried it, does it sometimes, or all of the above.\r\n<br><br>\r\nBut, of course, the desire or need to go gluten free doesn’t erase the cravings for baked goods, pancakes, breaded foods and the like — hence the onslaught of gluten-free flour blends and baking mixes that have flooded the market.\r\n<br><br>\r\nThere are about as many different brands of gluten-free flour as there are reasons to go gluten free, but not all of them are worth your hard-earned cash. Some have less-than-optimal ingredients, some contain items that may work for some people and not others (one major brand we tried has milk powder; fine for my family, but not anyone who’s cooking for someone with a dairy allergy), some just don’t work as well or impart a flavor you might not want. So how do you know which flour blend to buy?\r\n<br><br>\r\nAs a recipe developer who works frequently on healthy recipes, I\'ve come up with plenty of gluten-free dishes. And personally, my husband has an autoimmune disease, so he’s been gluten free for nearly three years. With all of that, I’ve tried many gluten-free flours, with mixed results (some are good for cookies but not so great for pancakes, others aren’t good for baking but work nicely as breading). So we created a more formal test, trying out seven popular brands of gluten-free flour in pancakes, shortbread and chicken cutlets (yep, I was very popular with my neighbors there for a while), to bring you the very best ones on the market.\r\n<br><br>\r\nHow We Tested\r\nI bought seven popular, commonly available brands of gluten-free flour, all of which claimed to be one-to-one replacements for wheat flour. For each, I made a batch of this shortbread and a batch of these pancakes, weighing the flour according to the measurements on the labels. Then I used each to bread chicken cutlets and pan-fried them in avocado oil. It’s been my experience anecdotally that some gluten-free flours work well for baking but for some reason can’t pull off pancakes, and that proved true here. Some were fine for baking and pancakes, but left me with a weird aftertaste on the chicken, a sort of tangy flavor that was less than desirable. I compared all of their prices, as well as noting the ingredients. Interestingly, one brand’s label was way off on the weight of the flour, so the shortbread was a complete bust. For the pancakes for just that brand I used the scoop/sweep method for measuring and it worked fine, though neither the pancakes nor the chicken held up to other brands. Though some brands did really well with one application but not others, I selected as favorites the ones that proved most versatile.\r\n<br><br>\r\nThis article has been reviewed since its original publish date for accuracy, pricing and availability. We stand by our list of top gluten-free flour picks', '2022-06-23'),
(7, 'Article2.png', 'The 10 Best Veggie Burgers, According to Nutritionists', 'Toby Amidor, M.S., R.D., C.D.N.', 'The frozen food aisle has come a long way, especially when it comes to plant-based patties.', 'The frozen food aisle has come a long way, especially when it comes to plant-based patties. With the rise in popularity of plant-based burgers comes an array of veggie burgers you can purchase at the store to heat and eat. Dietitians from around the country weighed in on their favorite store-bought veggie burgers. Below you’ll find some oldies but goodies, and some new kids on the block that you’ll want to give a try ASAP.\r\n<br><br>\r\nDr. Praeger\'s All American Veggie Burger\r\n$4.46 WALMART\r\nDr. Praeger’s is a favorite of many dietitians including Bonnie Taub-Dix, RDN, creator of BetterThanDieting.com, author of Read It Before You Eat It - Taking You from Label to Table. \"Their All American Veggie Burger supplies you with 28g of plant protein and a meaty texture and it’s also soy and gluten free,\" says Taub-Dix who explains that it’s important to check to see how much protein is in your burger — especially if you’re a vegetarian or vegan and this food is being relied upon as a major source of protein. \"Dr. Praeger’s makes veggie burgers with ingredients you can recognize.\" Taub-Dix also likes Dr. Praeger’s Sweet Heat Beet Burger that contains six vegetables along with a whopping 19g of plant-based protein in each serving.\r\n<br><br>\r\nMorningStar Farms Veggie Burgers\r\n$3.67 WALMART\r\nDietitians sure enjoy Morningstar Farms veggie burgers! Melissa Altman-Traub MS, RDN, LDN likes the Tex Mex variety because it’s spicy and have a great texture. \"Nutritionally, it provides 11g of protein and 10% of the daily value for iron, with only 1 gram of saturated fat and no cholesterol.\" Altman-Traub enjoys her veggie burger lightly grilled on a whole wheat bun with lettice, tomato, salsa or guac, and sautéed onions and peppers.\r\n<br><br>\r\nMichele Sidorenkov, RDN of My Millennial Kitchen also favors Morningstar Farms but chooses their Garden Veggie Burgers because \"they\'re made with real, everyday ingredients that you can actually see and pronounce. When you know that\'s in your food, you can feel good about what you are eating!\" Sidorenkov cooks her burger in a lightly oiled skillet because that seems to give me the best texture and burger-like sear. She then places her cooked burger on a bun and loads on the avocado, lettuce, tomato, and mustard.\r\n<br><br>\r\nBoca Original All American Non GMO Frozen Veggie Burgers\r\n$3.22 WALMART\r\n\"Boca Burgers are a veggie burger that you can’t beat for the taste, nutrition and price,\" says Dr. Joan Salge Blake, EdD, RDN, LDN, FAND, nutrition professor at Boston University, author, and host of the hit health and wellness podcast, SpotOn!. They are available in the frozen section of your supermarket and are made with soy, cheese, and yummy flavoring. \"The burger provides 13g of protein for about $1 per burger. It’s a vegetarian steal,\" explains Saldge Blake who enjoys them on a whole wheat burger bun topped with salsa and reduced fat pepper jack cheese for a burger with a kick.\r\n<br><br>\r\nHilary\'s, Organic The World\'s Best Veggie Burger\r\n$2.99 AMAZON\r\nSeveral dietitians claim Hilary’s to be their favorite including NYC-based Registered Dietitian, Rebecca Ditkoff, MPH RD CDN & founder of Nutrition by RD and Kellie Blake, RDN, LD, IFNCP of Nutrisense Nutrition. Ditkoff keeps a box as a staple in her freezer \"because it tastes amazing and has a great texture. Additionally, I love that they are made with simple ingredients, such as fiber-rich whole grains, kale, spinach and sweet potato and are lower in sodium compared to other veggie burgers.\" Blake also recommends these burgers to clients who must avoid ingredients like eggs, dairy, wheat/gluten, corn, soy and nuts. Blakes likes that \"they’re also convenient when you just don’t have time to a from scratch burger.\"\r\n<br><br>\r\nAmy’s Organic California Veggie Burger, Light in Sodium\r\n$5.49 TARGET\r\nNew York City culinary nutritionist Jackie Topol, MS, RD enjoys this veggie burger from Amy’s because it is \"made with mushrooms, whole grains, and walnuts which makes for a very hearty patty that has that perfect umami flavor.\" It’s also lower in sodium than most veggie burger with 270 mg per patty and doesn’t have any overly processed soy or mystery ingredients in it. Topol’s favorite way to eat it? Topped with lettuce, tomato, avocado and some organic ketchup without a bun and with baked sweet potato fries on the side.\r\n<br><br>\r\nSunshine Organic Veggie Burgers\r\n$5.49 INSTACART\r\nThese burgers are a favorite to several dietitians and there are many reasons why. Leanne Ray, MS, RDN, owner of Leanne Ray Nutrition loves Sunshine Burgers \"because of the super simple ingredients list and mild flavor. They are a bit unique containing just whole grains, vegetables and sunflower seeds with no fillers or preservatives.\"\r\n<br><br>\r\nMary Purdy, MS, RDN, Adjunct Professor at Bastyr University and host of Mary\'s Nutrition Show loves these burgers \"because this is a true to its name \'veggie\' burger, in that all of the ingredients are recognizable plant foods like carrots, black beans, brown rice and sunflower seeds, which means there\'s more whole-foods nutritional bang for the burger buck. They also have a variety of flavors to suit all palates, including those seeking a spicy kick.\" Plus, Purdy says that \"they are one of the few plant-based veggie burgers that actually have close to 10 grams of protein, which can help satiate and prevent cravings for....another burger!\"\r\n<br><br>\r\nField Roast Field Burger\r\n$8.17 INSTACART\r\nChloe Paddison, RDN, LD of Cureative Nutrition opts for Fieldburgers \"because it offers a great texture and flavor while holding together nicely in the cooking process.\" The base of the burger is mushrooms and Paddison says that \"it is definitely a prominent flavor along with the complimentary seasonings and other vegetables.\" This veggie burger also packs in 25g of protein with only 7g of net carbohydrates. \"This is unique, as most veggie burger alternatives come with higher carbohydrate amounts from the starchy vegetables used.\" Paddison eats her burgers on its own with ketchup and mustard, or crumbled as a taco filling.\r\n<br><br>\r\nGood Seed Burgers\r\n$5.99 MYLK GUYS\r\nJenna Gorham, RD, founder of Gorham Consulting Group says \"this is the best tasting veggie burger I\'ve had!\" Gorham likes that it uses just whole food ingredients, is lower in sodium than other packaged meals, and offers a good source of filling plant based protein and fiber. In addition, \"the consistency is perfect — not too moist, too dry or crumbly, like some can be,\" says Gorham who keeps them on hand for quick easy lunches and dinners. Gorham likes to top it with Dijon mustard or avocado slices (either with a bun or bun-less) and a big side salad or grilled veggies.\r\n<br><br>\r\nEngine2 Burgers\r\n$4.99 ENGINE2\r\n\"With only 15 mg sodium per burger and made with ingredients I’d use in my own kitchen,\" says Cathy Leman, MA, RD founder of dam. mad. About BREAST CANCER, \"my favorite packaged veggie burgers are by Engine2.\" Leman eats these burgers toasted on a whole wheat English muffin topped with avocado and red onions, uses two patties as the protein source over a salad, or as a filling for a veggie wrap.\r\n<br><br>\r\nTrader Joe\'s Thai Sweet Chili Veggie Burgers\r\n$3.69 (in-store purchase only) TRADER JOE\'S\r\n\"Made mainly with rice and vegetables, Thai Sweet Chili Veggie Burgers are a flavorful option for those looking for an alternative to traditional black bean burgers,\" touts Cassidy Reeser, RDN, LD and Owner at Cozy Peach Kitchen. \"With 8g of plant-based protein and 3g of fiber per patty, these veggie burgers deliver flavor without sacrificing nutrition.\"\r\n\r\nReeser enjoys her Trader Joe’s burger on a whole wheat bun with avocado, sautéed peppers and fresh spinach. \"Because the patties are so flavorful on their own, they also work well as a protein source in simple grain bowls or salads,\" says Reeser.\r\n<br><br>\r\nMandi Knowles, RDN, owner of The Well Crafted Life, a holistic health and wellness company is also a fan of Trader Joe’s but prefers the Vegetable Masala Burger. \"This Vegetable Masala Burger was one of the first ways Trader Joe’s stole my heart. This vegan burger packs a flavorful punch, unlike any other vegetable burger out there. It’s made with few, yet wholesome ingredients and literally takes less than 2 minutes to make,\" says Knowles who enjoys them in a whole wheat pita with avocado, shredded cheese, lettuce and tomato.', '2019-09-13'),
(8, 'Article3.webp', 'Honey Improves Metabolic Health As Per Study', 'Aditi Ahuja', 'Honey has once again proven to be a potent food for our health, with a study establishing its beneficial effects for cardiometabolic factors.', 'In a bid to maintain good health, we often think of making changes to our diet and lifestyle. We read about all sorts of diet hacks, tips and tricks that will keep our body in good shape and helps us stay fit. Honey, for instance, has been touted to be an elixir for multiple reasons. The sweet, sticky liquid has been the most popular home remedy for cold and cough and also helps promote weight loss. It is fat-free and rich in iron, calcium and other minerals. Honey is also a common substitute for sugar for the calorie-conscious. Recently, a study found that honey may also improve measures of cardiometabolic health, including blood sugar and cholesterol.\r\n<br><br>\r\nA new study was conducted by researchers at the University of Toronto in Canada and was published in the journal \'Nutrition Reviews\'. The scientists conducted 18 trials with over 1,100 participants over a median trial period of eight weeks. Two tablespoons or 40 grams was the median honey size served to the participants. Raw honey from a single floral source was used for the purpose of this study. The results of the study showed that honey lowered fasting blood glucose, total and bad cholesterol, triglycerides and markers of fatty liver disease. It also increased HDL or \"good,\" cholesterol and some markers of inflammation.\r\n<br><br>\r\nHoney can be added to the diet in various ways for maximum benefits. Photo Credit: \r\n\"These results are surprising because honey is about 80 percent sugar,\" said Tauseef Khan, a senior researcher from the Temerty Faculty of Medicine, University of Toronto. \"But honey is also a complex composition of common and rare sugars, proteins, organic acids and other bioactive compounds that very likely have health benefits.\"\r\nSo, if you want to include honey in your diet - we have just what you need! These five simple ways will ensure that you get some honey every day.Here Are 5 Simple Ways To Consume Honey:1. Banana Honey SmoothieCombine honey with some milk and banana, and any other seeds of your choice to make this simple and fuss-free smoothie. Click here for the full recipe.2. Honey Ginger LemonadeWant to keep it simple? This honey ginger lemonade recipe will surely come in handy. Find the recipe for this easy and refreshing drink here.\r\n(Also Read: Honey And Weight Loss: How Are The Two Connected?)\r\npltogjfo\r\n<br><br>\r\nGinger, honey and lemon tea can have a soothing effect on your throat. Photo Credit: iStock3. Honey CandiesIf you are suffering from a sore throat and want an easy home remedy, make these honey ginger candies. They will be a must-have part of your daily diet! Find the recipe here.4. Honey Lemon TeaSubstitute sugar in your usual lemon tea and add a tablespoon of honey instead. Your brew will become even more delicious and healthy too! Click here for more.5. Honey WaterA simple homemade drink, honey water is a great way to boost immunity and also make the most of honey\'s benefits. Click here to read the full recipe.\r\n<br><br>\r\nApart from this, you can always drizzle honey on your yogurt, spread it over some toasted bread or even use it as a salad dressing. So, make the most of this amazing natural offering and eat your way to good health!', '2022-10-02'),
(9, 'Article4.jpeg', 'How to Order Healthy at Any Restaurant', 'Kerri-Ann Jennings, M.S., R.D.', 'Eating out is one of the great joys of life. But if you\'re watching what you eat, a restaurant visit can sometimes feel like tiptoeing around nutritional land mines. Here are 10 top tips. ', 'Eating out is one of the great joys of life. But if you\'re watching what you eat, a restaurant visit can sometimes feel like tiptoeing around nutritional land mines. Here are 10 top tips. \r\n<br><br>\r\n1. Beware the word \"crispy\": \"Crispy\" is usually code for \"fried,\" and \"fried\" is code for \"dunked in batter and then plunged in oil\" — not the healthiest food choice you can make.\r\n<br><br>\r\n2. Go for grilled, baked, broiled, roasted, braised: These cooking methods don\'t require much added fat, so the dishes that are prepared this way may be healthier. That\'s not to say the chefs aren\'t also going to add rich sauces, though; ask about preparation methods.\r\n<br><br>\r\n3. Start off with a soup or salad: If you start your meal with soup or salad, you tend to eat less during the rest of your meal, according to research. Vegetable-based soups and salads are a good way to get some fiber and other nutrients into your meal, which starts to fill you up.\r\n<br><br>\r\n4. If you do get soup, choose one with a clear broth: For the healthiest start to your meal, skip the cream-based options. It’s usually a safe bet to order something like pasta e fagioli (which has chicken broth, beans, veggies and pasta) or minestrone, rather than cream of broccoli.\r\n<br><br>\r\n5. Order leaner cuts of meat: T-bone, sirloin, flank steak, strip steak and pot roast are all lean cuts of beef and will have fewer calories and less saturated fat than some of the other options on the menu. Poultry is also a smart way to go, as is seafood or tofu (as long as we’re not talking about deep-fried tofu or fish and chips).\r\n<br><br>\r\n6. Do your homework: If you\'re really watching what you eat, it may be helpful to read the menu before you get to the restaurant and decide what you\'re going to order. If you’re eating at a chain restaurant, you can even look up the nutritional information ahead of time so you can make the healthiest choice.\r\n<br><br>\r\n7. Avoid processed and highly fatty meats: Pork belly may be really popular on restaurant menus these days, but it’s essentially a really fatty piece of meat — not healthy. Likewise, bacon, sausage and short ribs are items to avoid when you\'re trying to eat healthfully. They have way too much saturated fat and (in the case of the processed meats) sodium to really be good for you.\r\n<br><br>\r\n8. Skip the bread: If bread is the favorite part of eating out, then sure, go for a slice. But unless the bread is really great, it’s often not worth it.\r\n\r\n9. Share dishes: A lot of restaurants serve way too much food. And while this may seem like a good value, it\'s really no bargain when it comes to your health. Your best bet is often to share a main dish. Then you can each start off with a side salad or soup. You get plenty of food (in an appropriate portion size), you save money and you keep calories and other numbers in check.\r\n<br><br>\r\n10. Order off the kids\' menu: Another way to sometimes get the most portion-size-appropriate dish is to order off the kids\' menu. Case in point: A burger on the kids\' menu is usually 3 to 4 ounces (i.e., the correct portion size for a serving of meat), whereas on the regular menu it\'s often 8 ounces (a half pounder). Likewise, kids\'-size fries or ice cream are not a huge calorie splurge, but you’ll get some of the indulgence you crave.\r\n', '2022-10-19'),
(10, 'Article5.jpg', 'What Nutrients You Absolutely Need When Pregnant', 'Kerri-Ann Jennings, M.S., R.D.', 'Wondering whether you’re getting the nutrients you need during your pregnancy? Find out five nutrients you should be getting and how to get them.', 'During pregnancy, it can be hard to know if you’re getting enough of the “right” foods (especially when morning sickness and changing taste buds can make your regular diet unpalatable).\r\n<br><br>\r\nIf you’re confused about what you should be eating, here’s a good place to start — after all, what goes in your body is now feeding you as well as someone new. These five nutrients offer specific things that you always need, but they are particularly important during pregnancy.\r\n<br><br>\r\nFolic acid: It’s recommended that all women of childbearing age get at least 400 micrograms of folic acid a day. That’s because this vitamin is critical during the first few weeks of pregnancy as your baby’s nervous system is developing. Shortfalls of folic acid can lead to neural tube defects. It’s also necessary to help you produce red blood cells. You can find it in lentils, beans, citrus fruit and juice, broccoli, spinach and other leafy greens. Enriched grains, such as bread and pasta, are also fortified with folic acid.\r\n<br><br>\r\nProtein: Protein is made of amino acids — your body’s “building blocks.” When your body is repairing itself, growing or pregnant, your protein needs increase. It’s recommended that pregnant women get 0.5 grams of protein per pound of body weight. A 130-pound woman would need at least 65 grams of protein a day. (For reference: A 3 ounce piece of chicken breast has 25 grams of protein, 1 cup of low-fat yogurt has 12 grams of protein and 2 tablespoons of peanut butter has 8 grams of protein).\r\n<br><br>\r\nIron: Your iron needs almost double during pregnancy. Iron helps carry oxygen to cells. While pregnant you should get 27 milligrams of iron a day. Because many women fall short of that requirement, the CDC recommends a daily supplement of 30 milligrams of iron to pregnant women. To help boost your iron intake through food, consider beans, spinach, blackstrap molasses, red meat, edamame and fortified cereals.\r\n<br><br>\r\nOmega-3s: Omega-3 fatty acids are long-chain, fluid fats that are important for the optimal functioning of all cells. That’s why Omega-3s are particularly important during pregnancy when your baby is building new cells every day. Some research has linked prenatal intake of Omega-3s (particularly DHA) to improved cognitive abilities in children.\r\n<br><br>\r\nCalcium: When you’re pregnant, your body becomes more efficient at using calcium, which is why your daily needs technically stay the same as when you’re not pregnant (1,000 milligrams). But here’s the key: When you don’t get enough calcium through diet, your body removes calcium from your bones, which can weaken your skeleton over time. Plus, calcium deficiency is linked to preeclampsia.', '2022-10-29');

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `id` int(11) NOT NULL,
  `u_id` int(11) NOT NULL,
  `item_name` varchar(255) NOT NULL,
  `item_detail` varchar(255) NOT NULL,
  `item_price` decimal(10,0) NOT NULL,
  `item_quantity` int(11) NOT NULL,
  `item_image` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `product_id` int(10) NOT NULL,
  `code` varchar(100) NOT NULL,
  `product_name` varchar(50) NOT NULL,
  `detail` varchar(100) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `category` varchar(20) NOT NULL,
  `product_image` varchar(100) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_id`, `code`, `product_name`, `detail`, `price`, `category`, `product_image`, `quantity`) VALUES
(1, 'chickenmeat', 'Chicken Meat (1kg)', 'Fresh chicken meat is well-preserved.', '21.99', 'Protein', 'chickenmeat.jpg', 1),
(2, 'salmon', 'Salmon (100g)', 'Fresh salmon is well-preserved.\r\n\r\n', '19.90', 'Protein', 'salmon.jpg', 1),
(3, 'strawberry', 'Strawberry (250g)', 'Fresh strawberry from farm.', '15.90', 'Fruits', 'strawberry.jpg', 1),
(4, 'apple', 'Apple (1pcs)', 'Fresh apple from farm.', '2.50', 'Fruits', 'apple.jpg', 1),
(5, 'orange', 'Orange (1pcs)', 'Fresh orange from farm.', '2.90', 'Fruits', 'orange1.jpg', 1),
(6, 'drumstick', 'Chicken Drumstick (4pcs)', 'Fresh chicken drumstick that is well preserved.', '9.60', 'Protein ', 'chicken_drumstick.jpg', 1),
(7, 'blueberry', 'Blueberry (125g)', 'Fresh blueberry from farm.', '13.90', 'Fruits', 'blueberry.jpg', 1),
(8, 'egg', 'Egg (30pcs)', 'Fresh egg from farm.', '23.90', 'Protein', 'egg1.jpg', 1),
(9, 'tomato', 'Tomato (1kg)', 'Fresh cherry tomato from farm.', '9.50', 'Fruits', 'tomato.jpg', 1),
(10, 'cabbage', 'Cabbage (500g)', 'Fresh cabbage from farm.', '6.90', 'Vegetables', 'cabbage.jpg', 1),
(11, 'broccoli', 'Broccoli (1pcs)', 'Fresh broccoli from farm.', '6.90', 'Vegetables', 'broccoli.jpg', 1),
(12, 'corn', 'Sweet Corn (1pcs)', 'Fresh sweet corn from farm.', '2.50', 'Vegetables', 'sweetcorn.jpg', 1),
(13, 'cucumber', 'Cucumber (500g)', 'Fresh cucumber from farm.', '3.50', 'Vegetables', 'cucumber.jpg', 1),
(14, 'avocado', 'Avacado (1pc)', 'Fresh avocado from farm.', '6.00', 'Fruits', 'avacado.jpg', 1),
(15, 'boc', 'Pretty Simple Cooking', 'Buy our cookbook, Pretty Simple Cooking!', '32.00', 'Book', 'cookBook1.webp', 0),
(16, 'ticket', 'Sweepstakes Ticket', 'A ticket to allow members to join the sweepstake event.', '12.00', 'Misc', 'Ticket.png', 0),
(17, 'ticket2', 'Sweepstakes Ticket Special', 'A ticket to allow members to join the sweepstake \r\nevent with higher chance of winning.', '50.00', 'Misc', 'TicketSpecial.png', 0),
(18, 'boc2', 'Good for You', 'This cookbook is chock-full of crowd-pleasing dishes.', '36.00', 'Book', 'cookBook2.webp', 0);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `pnum` varchar(11) NOT NULL,
  `password` varchar(255) NOT NULL,
  `subscription` varchar(10) NOT NULL,
  `address` text NOT NULL,
  `bio` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `email`, `pnum`, `password`, `subscription`, `address`, `bio`) VALUES
(12, 'Yan Xun', 'yanxun@gmail.com', '017-5443122', '1234', 'Member', '7-06, Pangsapuri Vista, Jalan Telaga Air, 12200', 'This is a bio'),
(13, 'sus', 'sus@gmail.com', '019-2345678', '1234', 'Normal', '', ''),
(14, '23123', '2131231@gmail.com', '01231232432', '12345', 'Normal', '', ''),
(15, 'yxtest', 'yx@gmail.com', '0192837462', '1234', 'Normal', '', ''),
(16, 'LeoLii', 'kjack0358@gmail.com', '01155854045', '1234', 'Member', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `article`
--
ALTER TABLE `article`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `article`
--
ALTER TABLE `article`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `product_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
