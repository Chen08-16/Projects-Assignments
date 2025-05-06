start :-
    write('Hi there! 👋 I\'m Lucy! I\'m your greenhouse manager for the day.'), nl,
    write('I\'m glad 😄 that you come to ask me about plants.'), nl,
    write('Currently I can provide you some tips on how to take care up to 4 specific plants for beginners. '), nl,
    write('The plants that you can ask about are Sunflower 🌻, Rose 🌹, Eggplant 🍆 and Tomato 🍅.'), nl,
  	menu.

menu:-
    nl,
 	write('Please tell me the plant that you are looking for its information.'), nl, 
    write('----------------------------------------------------------------------------------------'), nl,
    write('Enter \' 1 \' for information about Sunflower 🌻'), nl,                                      
    write('Enter \' 2 \' for information about Rose 🌹'), nl,  
    write('Enter \' 3 \' for information about Eggplant 🍆'), nl, 
    write('Enter \' 4 \' for information about Tomato 🍅'), nl,
    write('Enter \' 5 \' if you want to leave 🚪'), nl,
    write('----------------------------------------------------------------------------------------'), nl,
     read(Choice),
     (   
     	%if Sunflower is chosen
     	 (Choice == 1) -> 
            	write('Good choice! 👍 There are many uses and benefits for growing the Sunflower 🌻'), nl,
         		%proceed to the next step
               	categoryS(Choice)
       	 ;
     	%else if Rose is chosen
         (Choice == 2) ->
                write('Good choice ! 👍 Roses 🌹 are best known as ornamental plants grown for their flowers :)'), nl,
         		%proceed to the next step
                categoryR(Choice)
 		 ;
     	%else if Eggplant is chosen
         (Choice == 3) ->
                write('Good choice! 👍 The growing speed of Eggplant 🍆 is fast and it is good for health :)'), nl,
         		%proceed to the next step
                categoryE(Choice)
 		 ;
        %else if Tomato is chosen
        (Choice == 4) ->
                write('Good choice! 👍 Tomatoes 🍅 are easy to grow and it is delicious! :)'), nl,
         		%proceed to the next step
                categoryT(Choice)
 		 ;
       (Choice == 5) ->
                write('Goodbye! 👋 Looking forward to see you again! 😊')
 		 ;
     
     	% else the input is false
     	 write('Invalid input! Please enter the correct number or alphabet!'), nl,
         write('Example: 1,2,3 or a,b,c'), nl,
         %loop back / recurvise
         menu
     
    ).

categoryS(Choice):-
    write('Which category about the Sunflower 🌻 would you like to lean more about?'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
    write('\n a. Information of plant'),nl,         
	write('b. Ways to take care the plant'),nl,          
    write('c. Type of the plant'),nl,      
    write('d. Potting for plant'),nl,           
    write('e. Common pests for the plant'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
    %read input and change to string
    read_line_to_string(user_input,Lcategory),
     (categoryS(Choice , Lcategory) ->
                (   
                      	%check if the user input is available in the database
                        (Lcategory == "a") ->
                          run_S(a);
                        (Lcategory == "b") ->
                          run_S(b);
                		(Lcategory == "c") ->
                          run_S(c);
                		(Lcategory == "d") ->
                          run_S(d);
                		(Lcategory == "e") ->
                          run_S(e)
                       );
                      	write('Invalid input! Please enter the correct alphabet (in lower case*) for the option!'), write(Lcategory) ,nl,
                      	write('Please try again to enter the correct input!'), nl,
                      	categoryS(Choice)
).

run_S(a):-
 	write('Here\'re some information about the Sunflower 🌻 that you might need.'), nl,
    write('----------------------------------------------------------------------------------------'), nl,
    write('Information of Sunflower 🌻 : '), nl, 
    write('Common name: Common Sunflower'), nl,
    write('Botanical name: Helianthus'), nl,  
    write('Family: Asteraceae'), nl,  
    write('Mature size: 5 to 10 feet'), nl,  
    write('Sun exposure: Full sun (Minimum 6 hours of sun is required*)'), nl,  
    write('Soil type: Well-drained soils'), nl,  
    write('Soil pH: Neutral (6.5-7.5) or slightly acidic (6.0 - 6.8)'), nl,  
    write('Bloom time 🕒: 8 to 12 weeks'), nl,  
    write('Flower color: Orange 🟠, Yellow 🟡, Red 🔴'), nl,  
    write('Native Areas 🌎: North and South America'), nl,  
    write('----------------------------------------------------------------------------------------'), nl,
    write('Thats all the information I have about the Sunflower 🌻. Hope that it is useful to you! 😊'), nl,
    write('If you would like to look for the other details about the Sunflower 🌻, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
     read(Yn),
    (   
     	%if Sunflower is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Sunflower category page
               	categoryS(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
    	 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
       	run_S(a)
    ).

run_S(b):-
    write('Here\'re some useful tips for taking care of the Sunflower 🌻. '), nl,
    write('Light: '), nl,   
    write('Remember to place the sunflowers in an area where they\'re exposed to at least six hours of full sunlight ☀️ per day.'), nl, nl, 
    write('Soil: '), nl,  
    write('Sunflowers thrive in slightly acidic to somewhat alkaline soil (pH 6.0 to 7.5). '), nl,  
    write('It is recommended that the soil is nutrient-rich with organic matter or composted (aged) manure.'), nl, nl,
    write('Water: '), nl,  
    write('Sunflower require a lot of water to germinate.'), nl,
    write('After that, it require an inch of water per week during the growing season.'), nl,  
    write('Please remember to water the Sunflower to preventing wilting and do not overwater the plant.'), nl, nl, 
    write('Temperature: '), nl,  
    write('The optimal temperatures for growing sunflowers are between 70˚F to 78˚F.'), nl, 
    write('Please take not that sunflowers can tolerate high heat as long as their moisture needs are met.'), nl,nl,  
    write('Care Humidity: '), nl,
    write('The best humidity for the sunflower is around 9% to 10% moisture. '), nl, nl,
    write('Fertilizer: '), nl,
    write('The nitrogen applications of 50-75kg/ha are generally sufficient for the sunflowers.'), nl, nl,
    write('That\'re all the tips that I have for taking care of the sunflower. Hope that it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Sunflower 🌻, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Sunflower is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Sunflower category page
               	categoryS(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_S(b)
    ).

run_S(c):-  
    write('Here\'re some example of types of sunflower 🌻 that I have found for you!'), nl,
    write('Types of Sunflowers: '), nl,   
    write('\'Skyscraper\': A type of sunflower that can rises high above the ground and can reach heights of up to 12 feet.'), nl, nl,  
    write('\'Sundance Kid\': This sunflower is reaching about knee high with bicolor red and yellow petals.'), nl, nl, 
    write('\'Little Becka\': This sunflower looks great in gardens when wanting to add a little splash of color.'), nl, nl, 
    write('That\'s the types of sunflowers that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Sunflower 🌻, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Sunflower is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Sunflower category page
               	categoryS(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
        run_S(c)
    ).

run_S(d):- 
    write('Here\'re some informations on the potting requirement for sunflower 🌻.'), nl,
    write('Tips for potting: '), nl,   
    write('Sunflowers need well-draining soil that retains moisture. '), nl,  
    write('A good quality general purpose potting soil will work well for the sunflower.'), nl,  
    write('You can mix the potting medium with some vermiculite to lighten the weight for the larger pots.'), nl, nl, 
    write('That\'s the potting tips for sunflower that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Sunflower 🌻, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Sunflower is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Sunflower category page
               categoryS(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_S(d)
    ).

run_S(e):- 
	write('Here\'re some informations about common pests for sunflower 🌻.'), nl,
    write('Common pests for sunflower:'), nl,   
    write('Sunflower moth is the most common pests that can be found on a sunflower.'), nl,
    write('There are 3 species of sunflower moth can damage sunflower crops worldwide.'), nl, 
    write('You can apply insecticides when the sunflowers begin to shed pollen to reduce the chance for having sunflower moth on your sunflower.'), nl, nl,
    write('That\'s the info of common pests for sunflower that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Sunflower 🌻, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Sunflower is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Sunflower category page
               	categoryS(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_S(e)
    ).

categoryR(Choice) :-
    write('Which category about the Rose 🌹 would you like to lean more about?'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
    write('\n a. Information of plant'),nl,         
	write('b. Ways to take care the plant'),nl,          
    write('c. Type of the plant'),nl,      
    write('d. Potting for plant'),nl,           
    write('e. Common pests for the plant'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
     read_line_to_string(user_input,Lcategory),
     (categoryR(Choice , Lcategory) ->
                (   
                      	%check if the user input is available in the database
                        (Lcategory == "a") ->
                          run_R(a);
                        (Lcategory == "b") ->
                          run_R(b);
                		(Lcategory == "c") ->
                          run_R(c);
                		(Lcategory == "d") ->
                          run_R(d);
                		(Lcategory == "e") ->
                          run_R(e)
                       );
                      	write('Invalid input! Please enter the correct alphabet (in lower case*) for the option!'), write(Lcategory) ,nl,
                      	write('Please try again to enter the correct input!'), nl,
                      	categoryR(Choice)
                ).


%data for Rose 
run_R(a):- 
    write('Here\'re some information about the Rose 🌹 that you might need.'), nl,
    write('Information of Rose 🌹 : '), nl,   
    write('Common names: Rose'), nl,  
    write('Botanical name: Rosa rubiginosa'), nl,  
    write('Family: Rosaceae'), nl,  
    write('Mature size: 4 to 6 feet (typically), 3 to 4 feet (floribundas)'), nl,  
    write('Sun exposure: Full day of sun (minimum 4 hours'), nl,  
    write('Soil type: Well-drained, deep, and humus'), nl,  
    write('Soil pH: Slightly acidic (6 to 6.5)'), nl,  
    write('Bloom time 🕒: 5 to 7 week per cycle.'), nl,  
    write('Flower color: Red 🔴, Blue 🔵, White ⚪, Orange 🟠, etc.'), nl,  
    write('Native Areas 🌎: Asia (Mostly), Europe, North America, Northwestern Africa'), nl,nl,nl, 
    write('Thats all the information I have about the Rose 🌹. Hope that it is useful to you! 😊'), nl,
    write('If you would like to look for the other details about the Rose 🌹, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Rose is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Rose category page
               	categoryR(2)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_R(a)
    ).
    
run_R(b):- 
    write('Here\'re some useful tips for taking care of the Rose 🌹. '), nl,
    write('Light: '), nl,   
    write('It\'s recommended to let your Rose have around 6 to 8 hours of direct sun a day.'), nl,  
    write('The roses that are shade tolerant only need 4 to 6 hours of direct sun a day.'), nl, nl, 
    write('Soil: '), nl,  
    write('The soils that are sandy-loam, red-loam, silt-loam are best suited for rose cultivation.'), nl,  
    write('The ideal soil pH for rose cultivation is (6.0 to 7.5).'), nl, nl,
    write('Water: '), nl,  
    write('The roses require 10 litres of water (two to three times a week) in the first year after planting.'), nl,  
    write('After that, the roses will require one deep soak per week in the cooler months and twice for warm or hot climates.'), nl, nl,
    write('Temperature: '), nl,  
    write('The ideal temperature for roses are between 60˚F and 70˚F.'), nl, nl,  
    write('Humidity: '), nl,
    write('The ideal humidity for roses are around 60% to 70% moisture '), nl, nl, 
    write('Fertilizer: '), nl,
    write('Nitrogen (N), phosphorus (P), and potassium (K) are the main primary nutrients that are required by the roses to grow healthly.'), nl, nl,
    write('That\'re all the tips that I have for taking care of the rose. Hope that it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Rose 🌹, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Rose is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Rose category page
               	categoryR(2)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_R(b)
    ).

run_R(c):-     
    write('Here\'re some example of types of Rose 🌹 that I have found for you!'), nl,
    write('Types of Roses: '), nl,   
    write('Climbing Roses: Climb on fence, trellis, or downspout when they are growing. Some small tips for these types of roses are they produce more flowers when grown horizontally.'), nl, nl,  
    write('Floribunda Roses: It is a cross between Hybrid Tea and Polyantha roses. The blooms present in large clusters to give color over a long season.'), nl, nl, 
    write('Groundcover Roses: This type of rose also known as "Groundcover Roses" as they grow on the ground and only can reach up to 3 feet.'), nl, nl, 
    write('That\'s the types of rose that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Rose 🌹, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Rose is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Rose category page
               	categoryR(2)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
          run_R(c)
    ).

 run_R(d):- 
    write('Here\'re some informations on the potting requirement for Rose 🌹.'), nl,
    write('Tips for potting: '), nl,   
    write('Choose the right pot. You need to choose a contrainer in proportion to the size of your rose'), nl,  
    write('Plant in good soils. You can use high-quality soilless mix and amending it with compost for an extra nutritional boost.'), nl,  
    write('Provide plenty of sunlight. You need to plant your rose at a place where it can receive enough sunlight to grow healthly.'), nl, nl,
    write('That\'s the potting tips for rose that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Rose 🌹, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Rose is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Rose category page
               	categoryR(2)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
          run_R(d)
    ).

 run_R(e):- 
	write('Here\'re some informations about common pests for Rose 🌹.'), nl,
    write('Common pests for Rose: '), nl,   
    write('Aphids are the most common insect pests on roses. Aphids favor rapidly growing tissue such as buds and shoots.'), nl,
    write('You can mix 1 tablespoon of soap (unscented) with 1 litre of water and spray the rose over several days with this mixture.'), nl, nl,
    write('That\'s the info of common pests for rose that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Rose 🌹, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Rose is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Rose category page
               	categoryR(2)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
          run_R(e)
    ).

categoryE(Choice) :-
    write('Which category about the Eggplant 🍆 would you like to lean more about?'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
    write('\n a. Information of plant'),nl,         
	write('b. Ways to take care the plant'),nl,          
    write('c. Type of the plant'),nl,      
    write('d. Potting for plant'),nl,           
    write('e. Common pests for the plant'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
     read_line_to_string(user_input,Lcategory),
     (categoryE(Choice , Lcategory) ->
                (   
                      	%check if the user input is available in the database
                        (Lcategory == "a") ->
                          run_E(a);
                        (Lcategory == "b") ->
                          run_E(b);
                		(Lcategory == "c") ->
                          run_E(c);
                		(Lcategory == "d") ->
                          run_E(d);
                		(Lcategory == "e") ->
                          run_E(e)
                       );
                      	write('Invalid input! Please enter the correct alphabet (in lower case*) for the option!'), write(Lcategory) ,nl,
                      	write('Please try again to enter the correct input!'), nl,
                      	categoryE(Choice)
     ).

%data for Eggplant
run_E(a):- 
    write('Here\'re some information about the Eggplant 🍆 that you might need.'), nl,
    write('Information of Eggplant 🍆 : '), nl,   
    write('Common names: Brinjal, Aubergine, Guinea squash'), nl,  
    write('Botanical name: Solanum melongena L.'), nl,  
    write('Family: nightshade family (Solanaceae)'), nl,    
    write('Mature size: 18 to 36 inches tall'), nl,  
    write('Sun exposure: Full sun (minimum 6 hours of sunlight for a day*)'), nl,  
    write('Soil type: sandy loams'), nl,  
    write('Soil pH: Slightly acidic (6.0 to 7.0)'), nl,  
    write('Bloom time 🕒: around 2 months (after seeding)'), nl,  
    write('Flower color: White ⚪ to purple 🟣'), nl,  
    write('Native Areas 🌎: India, Africa, South Asia'), nl,nl,nl, 
    write('Thats all the information I have about the Eggplant 🍆. Hope that it is useful to you! 😊'), nl,
    write('If you would like to look for the other details about the Eggplant 🍆, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Eggplant is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Eggplant category page
               	categoryE(3)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_E(a)
    ).
    
run_E(b):- 
    write('Here\'re some useful tips for taking care of the Eggplant 🍆. '), nl,
    write('Light: '), nl,   
    write('Planting eggplant in a location that gets full sun for at least 6 to 8 hours of direct sunlight per day can help to get the best growth result.'), nl, nl, 
    write('Soil: '), nl,  
    write('Eggplant do best on light-textured soils such as sandy loams or alluvial soils that are deep and free draining.'), nl, nl,
    write('Water: '), nl,  
    write('You can water your eggplant deeply and infrequently and applying 1-2 inches per week. It is recommended to Use drip irrigation if possible.'), nl, nl,
    write('Temperature: '), nl,  
    write('The optimum daytime growing temperature ranges for eggplant is between 70°F and 85°F.'), nl, nl, 
    write('Humidity: '), nl,
    write('Eggplants are a warm season plant and the humidity and heat are not always their friend.'), nl, nl,
    write('Fertilizer: '), nl,
    write('The recommended dose for increasing the plant height and productivity of purple eggplant in vertisol is 15 t ha−1 of fermented compost and 225 kg ha−1 of N-fertilizer.'), nl, nl,
    write('That\'re all the tips that I have for taking care of the eggplant. Hope that it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Eggplant 🍆, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Eggplant is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Eggplant category page
               categoryE(3)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_E(b)
    ).

run_E(c):-     
    write('Here\'re some example of types of Eggplant 🍆 that I have found for you!'), nl,
    write('Types of Eggplants: '), nl,   
    write('American Eggplant: They have a short, squatty shape and a deep purple color. It\'s a great all-purpose eggplant, thanks to its meaty texture that makes it a great protein substitute.'), nl, nl,  
    write('Indian Eggplant: It is also known as "baby eggplants". They have a dark, reddish-purple color and a round shape. They\'re commonly used in Indian dishes like curry.'), nl, nl, 
    write('Japanese Eggplant: It has a slender, long shap, and deeper purple in color. They have a subtly-sweet flavor will meld nicely with any flavor pairing'), nl, nl, 
    write('That\'s the types of eggplant that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Eggplant 🍆, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Eggplant is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Eggplant category page
               	categoryE(3)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_E(c)
    ).

run_E(d):- 
    write('Here\'re some informations on the potting requirement for Eggplant 🍆.'), nl,
    write('Here is an advice about potting an repotting the plant'), nl,
    write('Tips for potting: '), nl,   
    write('When potting, it is recommended to plant one eggplant per container (2-gallon minimum).'), nl,  
    write('You can fill the container with a high quality potting soil that will drain quickly.'), nl,  
    write('Remember to water deeply and consistently for the eggplant but don\'t overwater it.'), nl, 
    write('You can also add a balanced, slow-release fertilizer at planting and then every few weeks during the season, especially when plants start to bloom.'), nl, nl,
    write('That\'s the potting tips for eggplant that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Eggplant 🍆, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Eggplant is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Eggplant category page
               	categoryE(3)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_E(d)
    ).

run_E(e):- 
	write('Here\'re some informations about common pests for Eggplant 🍆.'), nl,
    write('Common pests for Eggplant: '), nl,   
    write('The eggplant flea beetle and the eggplant lace bug are common pests that can be found in a eggplant farm.'), nl,
    write('You need to take note on a pest named twospotted spider mites because it can bring a lot of damage to you eggplant.'), nl, 
    write('You need to avoid over fertilizing with nitrogen because it will make the eggplant more attractive to pest such as aphids.'), nl, nl,
    write('That\'s the info of common pests for eggplant that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Eggplant 🍆, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Eggplant is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Eggplant category page
               	categoryE(3)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_E(e)
    ).

categoryT(Choice):-
    write('Which category about the Tomato 🍅 would you like to lean more about?'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
    write('\n a. Information of plant'),nl,         
	write('b. Ways to take care the plant'),nl,          
    write('c. Type of the plant'),nl,      
    write('d. Potting for plant'),nl,           
    write('e. Common pests for the plant'),nl,
    write('----------------------------------------------------------------------------------------'), nl,
    %read input and change to string
    read_line_to_string(user_input,Lcategory),
     (categoryT(Choice , Lcategory) ->
                (   
                      	%check if the user input is in the database
                        (Lcategory == "a") ->
                          run_T(a);
                        (Lcategory == "b") ->
                          run_T(b);
                		(Lcategory == "c") ->
                          run_T(c);
                		(Lcategory == "d") ->
                          run_T(d);
                		(Lcategory == "e") ->
                          run_T(e)
                       );
                      	write('Invalid input! Please enter the correct alphabet (in lower case*) for the option!'), write(Lcategory) ,nl,
                      	write('Please try again to enter the correct input!'), nl,
                      	categoryT(Choice)
).

run_T(a):-
 	write('Here\'re some information about the Tomato 🍅 that you might need.'), nl,
    write('Information of Tomato 🍅: '), nl,   
    write('Common names: Tomato'), nl,  
    write('Botanical name: Solanum lycopersicum'), nl,  
    write('Family: Solanaceae'), nl,  
    write('Mature size: Easily grow to 3 to 4 feet tall'), nl,  
    write('Sun exposure: Full sun (at least six hours per day*)'), nl,  
    write('Soil type: Well-drained, fertile loam'), nl,  
    write('Soil pH: Slightly acidic (6.0 to 6.8)'), nl,  
    write('Bloom time 🕒: Approximately 20 to 60 days'), nl,  
    write('Flower color: yellow 🟡'), nl,  
    write('Native Areas 🌎: Americas, Andes, Bolivia, etc.'), nl, nl, nl,
    write('Thats all the information I have about the Tomato 🍅. Hope that it is useful to you! 😊'), nl,
    write('If you would like to look for the other details about the Tomato 🍅, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
     read(Yn),
    (   
     	%if Tomato is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Tomato category page
               	categoryT(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
       	run_T(a)
    ).

run_T(b):-
    write('Here\'re some useful tips for taking care of the Tomato 🍅. '), nl,
    write('Light: '), nl,   
    write('The tomatoes needs at least 8 hours a day of sunlight to produce fruit, but you can aim to provide 12 -16 hours of light for the best growing results.'), nl, nl, 
    write('Soil: '), nl,  
    write('Tomatoes will produce good yields on a wide range of fertile, well drained soils with pH of (5.5 – 7.5).'), nl,  
    write('You can mix several inches of organic compost or aged animal manure into the upper 4-8 inches of soil before planting.'), nl, nl,
    write('Water: '), nl,  
    write('You can water your tomato daily in the morning in the early of the growing season.'), nl,  
    write('Take note that you might need to water your tomatoes twice a day as the temperature increase.'), nl, nl, 
    write('Temperature: '), nl,  
    write('Tomatoes do not thrive in cold weather or extreme heat.'), nl, 
    write('The minimum temperature is around 10˚C with the maximum being 34˚C. The optimum temperature is between 26 and 29˚C.'), nl, nl,  
    write('Humidity: '), nl,
    write('For the optimal development of the tomato plant, a relative humidity between 65% and 85% is required. '), nl, nl,
    write('Fertilizer'), nl,
    write('Just mix the fertilizer in the watering can at a rate of about 1 tablespoon (15 ml) per gallon (4 L). Apply every one to two weeks throughout the season. '), nl, 
    write('Please remember to avoid applying fertilizer during very hot or very dry conditions.'), nl, nl,
    write('That\'re all the tips that I have for taking care of the tomato. Hope that it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Tomato 🍅, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Tomato is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Tomato category page
               	categoryT(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_T(b)
    ).

run_T(c):-  
    write('Here\'re some example of types of Tomato 🍅 that I have found for you!'), nl,
    write('Types of Tomatoes: '), nl,   
    write('\'Cherry tomatoes\': Cherry tomatoes are round, bite-sized, and so juicy that they may pop when you bite into them. They’re the perfect size for salads or to eat alone as a snack.'), nl, nl,  
    write('\'Green tomatoes\': Green tomatoes can be divided into two types which are the heirlooms that turn green when fully ripe and unripened ones that have not yet turned red.'), nl, nl, 
    write('\'Grape tomatoes\': These tomatoes don\'t contain as much water and have an oblong shape. They are excellent in salads or eaten alone as a snack.'), nl, nl, 
    write('That\'s the types of eggplant that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Tomato 🍅, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Tomato is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Tomato category page
               	categoryT(1)
       	 ;
     	%else if back is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is wrong
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
        run_T(c)
    ).

run_T(d):- 
    write('Here\'re some informations on the potting requirement for Tomato 🍅.'), nl,
    write('Tips for potting: '), nl,   
    write('You can choose sandy loam soil for you plan as it is soil made up of clay, silt, and sand. This is the ideal organic potting mix to grow tomatoes since it drains well.'), nl,  
    write('You also need to choose the right type of tomato that is suitable for your planting environment.'), nl,  
    write('The larger pot you used for your tomato can make the growing better.'), nl, nl, 
    write('That\'s the potting tips for tomato that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Tomato 🍅, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Tomato is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Tomato category page
               categoryT(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_T(d)
    ).

run_T(e):- 
	write('Here\'re some informations about common pests for Tomato 🍅.'), nl,
    write('Common pests for tomatoes: '), nl,   
    write('Aphids are the most common insect pests on fruit plant. Aphids favor rapidly growing tissue such as buds and shoots.'), nl, 
    write('You can mix 1 tablespoon of soap (unscented) with 1 litre of water and spray the rose over several days with this mixture.'), nl, nl,
    write('That\'s the info of common pests for tomato that I can find for you. Hope it will be useful to you!'), nl,
    write('If you would like to look for the other details about the Tomato 🍅, please enter "y" for yes.'), nl,
    write('If no, please enter "n" for no. I will bring you back to the menu for the plant seclection'), nl,
    read(Yn),
    (   
     	%if Tomato is chosen
     	 (Yn == y) -> 
            	write('Redirecting you to the category page. Please give me a moment.'), nl,
         		%move to Tomato category page
               	categoryT(1)
       	 ;
     	%else if return is chosen
         (Yn == n) ->
                write('Redirecting you to the menu for plant selection. Please give me a moment.'), nl,
         		%move to menu page
                menu
 		 ;
     	% else the input is false
		 write('Invalid input! Please enter "y" or "n" (in lower case only*)'), nl,
         write('Please try to enter the correct input again.'), nl,
         %loop back / recurvise
         run_T(e)
    ).


% facts
%category
categoryS(1, "a").
categoryS(1, "b").
categoryS(1, "c").
categoryS(1, "d").
categoryS(1, "e").

categoryR(2, "a").
categoryR(2, "b").
categoryR(2, "c").
categoryR(2, "d").
categoryR(2, "e").

categoryE(3, "a").
categoryE(3, "b").
categoryE(3, "c").
categoryE(3, "d").
categoryE(3, "e").

categoryT(4, "a").
categoryT(4, "b").
categoryT(4, "c").
categoryT(4, "d").
categoryT(4, "e").

