<?php
session_start();

require_once "config.php";

$sql = "SELECT * FROM article";
$result = $link->query($sql);

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
    <title>Good Food Articles</title>
</head>

<body style="background-image:url(../GoodFood/images/bg.png);">
<?php
  if (isset($_SESSION['id']) && (isset($_SESSION['username'])) && (isset($_SESSION['rank']))) {
    if($_SESSION['rank'] == 'Normal'){
      include "./header-normal.php";
    }else{
      include "./header-member.php";
    }
  } elseif (!isset($_SESSION['id']) && (!isset($_SESSION['username'])) && (!isset($_SESSION['rank']))) {
    include "./header.php";
  }
  ?>

    <!--Main-->
    <div class="articleMain">
        <main style="padding:80px 10px 10px 100px; margin-left:auto; margin-right:auto; width:75%;">
        <br>
            <h2>Articles</h2>
            <hr>
            <?php if ($result->num_rows > 0) {
                // Bind variables to the prepared statement as parameters
                while ($row = $result->fetch_assoc()) {
                    echo '<div class="card mb-3">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="../GoodFood/images/'.$row['image'].'" class="img-fluid rounded-start" alt="..." style="object-fit:cover; height: 280px; width: 450px;">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body" style="max-height: 270px;">
                                <h4 class="card-title">' . $row["title"] . '</h4>
                                <h8 class="card-text">By ' . $row["author"] . '</h8>
                                <br><br>
                                <p class="card-text">' . $row["c_description"] . '</p>
                                <p class="card-text"><small class="text-muted">' . $row["date"] . '</small></p>
                                <a href="readarticle.php?id=' . $row["id"] . '" class="btn btn-primary" id="1" style="background-color:black; border-color:black;">Read More ></a>
                            </div>
                        </div>
                    </div>
                </div>';
                }
            }
            ?>

        </main>
    </div>


    <?php include "./footer.php" ?>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
</body>

</html>