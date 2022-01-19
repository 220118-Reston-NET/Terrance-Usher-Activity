#Terrance Usher
#January 18, 2022

restart="True"
while [ $restart == "True" ]
do

echo "Hello User would you like to watch a show or movie?"
echo "If show then input 1, if movie then input 2, if neither then input 3."
read input

echo ""

if [ "$input" == "1" ]
then
wrong="True"  #Setting the value for the wrong variable for the while loop.
while [ $wrong == "True" ]
do
echo ""
echo "Awesome then you can watch the hit show The Adventures of Jimmy Neutron, Boy Genius!"
echo "What episode number do you want to watch? (1 - 60)"
read input2

echo""

if [ 60 -ge $input2 ]
then
if [ $input2 -ge 1 ]
then
echo ""
echo "ah, episode $input2 good choice."
wrong="False"  #After the user correctly inputs the episode wrong is false so the loop ends.

else
echo ""
echo "There is no episode before episode 1!"
fi

else
echo ""
echo "There is no episode after episode 60!"
fi
done
restart="False"

elif [ "$input" == "2" ]
then
echo "Cool then get ready to watch the hit movie Jimmy Neutron: Boy Genius!"
restart="False"

elif [ "$input" == "3" ]
then
echo "Booooo no Jimmy Neutron for you then. Bye."
restart="False"

else
echo ""
echo "Please enter 1, 2, or  3."
echo ""

fi
done
