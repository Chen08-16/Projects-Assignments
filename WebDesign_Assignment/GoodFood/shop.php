<?php
session_start();

require_once "config.php";

$sql = "SELECT * FROM product ORDER BY product_id";
$resultItem = $link->query($sql);

?>

<?php
$status = "";
if (isset($_POST['code']) && $_POST['code'] != "") {
  $code = $_POST['code'];
  $result = mysqli_query(
    $link,
    "SELECT * FROM `product` WHERE `code`='$code'"
  );
  $row = mysqli_fetch_assoc($result);
  $name = $row['product_name'];
  $code = $row['code'];
  $price = $row['price'];
  $image = $row['product_image'];
  $category = $row['category'];

  $cartArray = array(
    $code => array(
      'product_name' => $name,
      'code' => $code,
      'price' => $price,
      'product_image' => $image,
      'category' => $category,
      'quantity' => 1
    )
  );

  if (empty($_SESSION["shopping_cart"])) {
    $_SESSION["shopping_cart"] = $cartArray;
    echo "<script>alert('Item added to cart!');</script>";
  } else {
    $array_keys = array_keys($_SESSION["shopping_cart"]);
    if (in_array($code, $array_keys)) {
      echo "<script>alert('Item already in cart!');</script>";
    } else {
      $_SESSION["shopping_cart"] = array_merge(
        $_SESSION["shopping_cart"],
        $cartArray
      );
      echo "<script>alert('Item added to cart!');</script>";
    }
  }
}
?>

<!DOCTYPE html>
<html class="articlesmain-bg" lang="en">

<head>
  <meta charset="UTF-8">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  <link rel="stylesheet" href="style.css">
  <title>Good Food Shop</title>
</head>

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

  <!--Main-->
  <div class="productMain">
    <main style="padding:80px 10px 10px 100px; margin-left:auto; margin-right:auto; width:75%;">
      <br>
      <h1>Products</h1><br>

      <div style="text-align:right;">

        <div style="text-align:right;">
          <div id="myBtnContainer">
            <button class="btnFilter active" onclick="filterSelection('All')"> All Products</button>
            <button class="btnFilter" onclick="filterSelection('Fruits')"> Fruits</button>
            <button class="btnFilter" onclick="filterSelection('Vegetables')"> Vegetables</button>
            <button class="btnFilter" onclick="filterSelection('Protein')"> Proteins</button>
            <button class="btnFilter" onclick="filterSelection('Book')"> Books</button>
            <button class="btnFilter" onclick="filterSelection('Misc')"> Miscellaneous</button>
          </div>
        </div>

        <hr>
        <div class="shopContainer">
          <?php if ($resultItem->num_rows > 0) {
            // Bind variables to the prepared statement as parameters
            while ($rowItem = $resultItem->fetch_assoc()) {
              echo '<form method="post" action="">
                    <div class="filterDiv ' . $rowItem['category'] . '">
                    <div class="card mb-3">
                    <div class="row g-0">
                        <div class="col-md-4">

                        <img src="../GoodFood/images/' . $rowItem["product_image"] . '" style="width:445px; height:270px;object-fit:cover;">

                        </div>
                        <div class="col-md-8">
                            <div class="card-body" style="max-height: 270px;">
                                <input type="hidden" name="code" value=' . $rowItem['code'] . ' />
                                <h3 class="card-title">' . $rowItem["product_name"] . '</h3><br>
                                <h6 class="card-text">' . $rowItem["detail"] . '</h6><br><br>
                                <h4 class="card-text">RM ' . $rowItem["price"] . '</h4>
                                <div class="col-md-3 col-lg-3 col-xl-2 d-flex" style="right:0;">
                            </div>
                            <div style="text-align:right; padding-bottom:10px;">';
                            if(isset($_SESSION["id"])){
                              echo '<button type="submit" class="btn btn-primary" style="background-color:black; border-color:black;margin-top:10px;">Add to Cart</button>';
                            }else{
                              echo '<a href="register.php" class="btn btn-primary" style="background-color:black; border-color:black;margin-top:10px;">Sign in to buy</a>';
                            }
                            echo '</div>
                        </div>
                  </div>
                  </div>
                  </div>
                  </div>
                  </form>
                ';
            }
          }
          ?>
        </div>
    </main>
  </div>

  <?php include "./footer.php" ?>

  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
</body>

</html>

<script>
  filterSelection("All")

  function filterSelection(c) {
    var x, i;
    x = document.getElementsByClassName("filterDiv");
    if (c == "All") c = "";
    // Add the "show" class (display:block) to the filtered elements, and remove the "show" class from the elements that are not selected
    for (i = 0; i < x.length; i++) {
      w3RemoveClass(x[i], "show");
      if (x[i].className.indexOf(c) > -1) w3AddClass(x[i], "show");
    }
  }

  // Show filtered elements
  function w3AddClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
      if (arr1.indexOf(arr2[i]) == -1) {
        element.className += " " + arr2[i];
      }
    }
  }

  // Hide elements that are not selected
  function w3RemoveClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
      while (arr1.indexOf(arr2[i]) > -1) {
        arr1.splice(arr1.indexOf(arr2[i]), 1);
      }
    }
    element.className = arr1.join(" ");
  }

  // Add active class to the current control button (highlight it)
  var btnContainer = document.getElementById("myBtnContainer");
  var btns = btnContainer.getElementsByClassName("btnFilter");
  for (var i = 0; i < btns.length; i++) {
    btns[i].addEventListener("click", function() {
      var current = document.getElementsByClassName("active");
      current[0].className = current[0].className.replace(" active", "");
      this.className += " active";
    });
  }
</script>