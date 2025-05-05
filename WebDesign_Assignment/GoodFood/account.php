<?php
session_start();

require_once "config.php";

$sql = "SELECT * FROM user WHERE id = '" . $_SESSION['id'] . "'";
$result = $link->query($sql);
$row = $result->fetch_assoc();

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" href="style.css">
    <title>Account Page</title>
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
    <?php
    if ($result->num_rows != 0) {
            echo '<div class="container emp-profile" style="background-color:white; margin-top:100px; margin-bottom:30px;">
            <form method="post">
                <div class="row">
                    <div class="col-md-4">
                        <div class="profile-img">
                            <img src="../GoodFood/images/profilep.jpg" alt="profilepicture" style="left:0;height:150px;object-fit:cover;"/>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="profile-head">
                                    <h5>
                                        Hello, ' . $row['username'] . '!
                                    </h5>
                                    <p class="proile-rating">STATUS : <span>' . $row['subscription'] . '</span></p>'; 
                                    if(isset($_SESSION["rank"]) && $_SESSION["rank"] != 'Normal')
                                    {
                                        echo '<a href="subscription.php?rank=Normal" class="btn btn-primary" style="background-color:black; border-color:black;">Unsubscribe</a>';
                                    }else{
                                        echo '<a href="subscription.php" class="btn btn-primary" style="background-color:black; border-color:black;">Upgrade now ></a>';
                                    }
    
                                    echo '<hr>
                        </div>
                    </div>
                    <div class="col-md-2">
                    <a href="edit-profile.php" class="btn btn-primary" id="1" style="background-color:black; border-color:black;">Edit Profile</a>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="profile-work">
                            <p>LINK</p>
                            <a href="">Website Link</a><br/>
                            <a href="">Social Media Link</a><br/>
                            <a href="">LinkedIn Link</a>
                            <p>CONTACTS</p>
                            <a href="">Personal Chef</a><br/>
                            <a href="">Article Author</a><br/>
                            <a href="">Customer Service</a><br/>
                            <a href="">Delivery</a><br/>
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="tab-content profile-tab" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" style="width:75%;" aria-labelledby="home-tab">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Username</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>' . $row['username'] . '</p>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Email</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>' . $row['email'] . '</p>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Phone Number</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>' . $row['pnum'] . '</p>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Address</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>' . $row['address'] . '</p>
                                            </div>
                                        </div>
                            </div>
                            <div class="row" style="margin-top:10px;">
                                <div class="col-md-12">
                                    <label>Your Bio</label><br/>
                                    <textarea readonly style="margin-top:10px; width:75%; height:200px;padding:10px;">'.$row['bio'].'</textarea>
                                </div>
                            </div>
                        </div>
                     </div>
                </div>
            </div>
        </form>           
    </div>';
        }

    ?>



    <?php include "./footer.php" ?>

</body>

</html>