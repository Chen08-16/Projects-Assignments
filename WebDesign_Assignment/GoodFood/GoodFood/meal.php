<?php
session_start();
require_once "config.php";

$sql = "SELECT * FROM product ORDER BY product_id";
$result = $link->query($sql);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <title>Good Food Meal Plan</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />

</head>
<style type="text/css">
.mealClass{
        padding-left:100px;
        padding-bottom:50px;
    }
    .mealOne{
        display:flex;
    }

    .positionOne{
        width:30%; 
        margin-left:10px; 
        margin-right:5%; 
        margin-top:10px;
    }

    .mealTwo{
        width:50%; 
        margin-left:5%; 
        margin-right:10px; 
        margin-top:10px;
    }



</style>

<body style="background-image:url(../GoodFood/images/bg.png);">
<?php
  if (isset($_SESSION['id']) && (isset($_SESSION['username'])) && (isset($_SESSION['rank']))) {
    if($_SESSION['rank'] == 'Normal'){
      include "./header-normal.php";
    }else{
      include "./header-member.php";
    }
  } elseif (!isset($_SESSION['id']) && (!isset($_SESSION['username']))) {
    include "./header.php";
  }
  ?>

<br>

<main class="mealClass">  
    <div class="mealOne">
        <div class="positionOne">
            <h4>Please select the type of diet:</h4>
                            <ul class="list-group">
                                <li class="list-group-item">
                                    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="firstRadio" onclick="checkFunction(this)" checked>
                                    <label class="form-check-label" for="firstRadio">Keto</label>
                                </li>
                                <li class="list-group-item">
                                     <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="secondRadio" onclick="checkFunction(this)">
                                    <label class="form-check-label" for="secondRadio">Vegan</label>
                                </li>
                                <li class="list-group-item">
                                    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="thirdRadio" onclick="checkFunction(this)">
                                    <label class="form-check-label" for="thirdRadio">Pecastarian</label>
                                </li>
                                <li class="list-group-item">
                                    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="forthRadio" onclick="checkFunction(this)">
                                    <label class="form-check-label" for="forthRadio">Dairy Free</label>
                                </li>
                                <li class="list-group-item">
                                    <input class="form-check-input me-1" type="radio" name="listGroupRadio" value="" id="fifthRadio" onclick="checkFunction(this)">
                                    <label class="form-check-label" for="fifthRadio">Gluten Free</label>
                                </li>
                            </ul>

        </div>

        <div class="mealTwo">
            <h4>Meal Plan Suggest:</h4>
                    <div>
                        <ul class="list-group list-group-hidden" id="text1" style="display:block;">
                                <img src="../GoodFood/images/keto.jpg" id="img1" class="imageClass" alt="ImageOne" style="padding:70px; height:600px;display:block;"><br>
                                <h5>For a healthy keto diet:</h5>
                                <li>Meat: red meat, steak, ham, sausage, bacon, chicken, and turkey</li>
                                <li>Fatty Fish: salmon, trout, tuna, and mackerel</li>
                                <li>Cheese: unprocessed cheeses like cheddar, goat, cream, blue, or mozzarella</li>
                                <li>Nuts and seeds: almonds, walnuts, flaxseeds, pumpkin seeds, chia seeds, etc.</li>
                        </ul>
                    </div>

                    <div>
                        <ul class="list-group list-group-hidden" id="text2" style="display:none;">
                            <img src="../GoodFood/images/vegan.jpg" id="img2" class="imageClass" alt="ImageTwo" style="padding:70px; height:600px;"><br>
                                <h5>For a healthy vegan diet:</h5>
                                <li>eat at least 5 portions of a variety of fruit and vegetables every day</li>
                                <li>base meals on potatoes, bread, rice, pasta or other starchy carbohydrates (choose wholegrain where possible)</li>
                                <li>have some fortified dairy alternatives, such as soya drinks and yoghurts (choose lower-fat and lower-sugar options)</li>
                                <li>eat some beans, pulses and other proteins</li>
                                <li>have fortified foods or supplements containing nutrients that are more difficult to get through a vegan diet, including vitamin D, vitamin B12, iodine, selenium, calcium and iron</li>
                        </ul>
                    </div>
                    <div>

                        <ul class="list-group list-group-hidden" id="text3" style="display:none;">
                            <img src="../GoodFood/images/pescetarian.jpg" id="img3" class="imageClass" alt="ImageThree" style="padding:70px; height:600px;"><br>
                                <h5>For a healthy pescetarian diet:</h5>
                                <li>Whole grains and grain products</li>
                                <li>Nuts and nut butters, peanuts and seeds</li>
                                <li>Seeds, including hemp, chia and flaxseeds</li>
                                <li>Dairy, including yogurt, milk and cheese</li>
                                <li>Fruits, Vegetables, Fish and shellfish, Eggs</li>
                        </ul>
                    </div>
                    <div>
                        <ul class="list-group list-group-hidden" id="text4" style="display:none;">
                            <img src="../GoodFood/images/dairyfree.jpg" id="img4" class="imageClass" alt="ImageFour" style="padding:70px; height:600px;"><br>
                                <h5>For a healthy dairy free diet:</h5>
                                <li>Soy products, such as tofu and tempeh</li>
                                <li>Whole grains, such as quinoa and couscous</li>
                                <li>Healthy fats, such as olive and coconut oil</li>
                                <li>Herbs & spices, Dark chocolate (double check for milk)</li>
                                <li>Dairy-free alternatives, such as nut milk, cream, cheese and yoghurt</li>
                        </ul>
                    </div>
                    <div>
                        <ul class="list-group list-group-hidden" id="text5" style="display:none;">
                            <img src="../GoodFood/images/glutenfree.jpg" id="img5" class="imageClass" alt="ImageFive" style="padding:70px; height:600px;"><br>
                                <h5>Many naturally gluten-free foods can be a part of a healthy diet:</h5>
                                <li>Fruits and vegetables</li>
                                <li>Beans, seeds, legumes and nuts in their natural, unprocessed forms</li>
                                <li>Lean, nonprocessed meats, fish and poultry</li>
                                <li>Most low-fat dairy products</li>
                                <li>Grains, starches or flours that can be part of a gluten-free diet include: Amaranth, Arrowroot, Buckwheat</li>
                        </ul>
                    </div>

        </div>

</main>

<?php include "./footer.php" ?>

    
<script>
function checkFunction(checkbox) {
  var meal1 = document.getElementById("firstRadio");
  var meal2 = document.getElementById("secondRadio");
  var meal3 = document.getElementById("thirdRadio");
  var meal4 = document.getElementById("forthRadio");
  var meal5 = document.getElementById("fifthRadio");



if (meal1.checked == true){
    img1.style.display = "block";
    text1.style.display = "block";
}else{
    img1.style.display = "none";
    text1.style.display = "none";
}

if (meal2.checked == true) {
    img2.style.display = "block";
    text2.style.display = "block";
}else{
    img2.style.display = "none";
    text2.style.display = "none";
}

if (meal3.checked == true) {
    img3.style.display = "block";
    text3.style.display = "block";
}else{
    img3.style.display = "none";
    text3.style.display = "none";
}

if (meal4.checked == true) {
    img4.style.display = "block";
    text4.style.display = "block";
}else{
    img4.style.display = "none";
    text4.style.display = "none";
}

if (meal5.checked == true) {
    img5.style.display = "block";
    text5.style.display = "block";
}else{
    img5.style.display = "none";
    text5.style.display = "none";
}


}
</script>
</body>
</html>



