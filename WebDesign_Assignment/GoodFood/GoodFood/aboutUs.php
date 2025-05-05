<?php
session_start();

?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="style.css" />
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="
    sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css%22%3E">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="
    sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="
    sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="
    sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
  <title>Good Food About Page</title>
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

  <main>
    <div style="padding: 0 200px 0 200px;">
      <table class="contactLayout1">
        <tr>
          <td>
            <div>
              <div class="contactTitle">Who we are</div>
              <p class="contactDetail1">Want to know more about us?</p><br><br>
              <div class="contactDetail3">History of Good Food Company</div><br>
              <p class="contactDetail2">Goodfood was established in 2014 by Jonathan Ferrari and Neil Cuggy, two<br>
                former investment banking analysts at RBC Capital Markets, under the original<br>
                name Culiniste. They were soon joined by Raffi Krikorian. The service grew in<br>
                popularity and began enrolling hundreds of subscribers per week.
              </p><br>

              <div class="contactDetail3">Access to information</div><br>
              <p class="contactDetail2">Good Food provide information and articles that are related to the famous<br>
                chef around the world, good food recipes, guide for healthy diet, source of<br>
                good ingredients. The articles and information in the website will update<br>
                frequently so be sure not to miss it.
              </p><br>

              <div class="contactDetail3">Good Food's Goals</div><br>
              <p class="contactDetail2">The company want to help people who is interested or facing problem with<br>
                their food plan. The main goal of the company is to make the daily life of<br>
                others to be more interesting and easier when in come to topics and works<br>
                that are related to food.
              </p><br>
            </div>
          </td>
          <td style="width:40%;">
            <div>
              <img src="../GoodFood/images/aboutus.jpg" class="img-fluid rounded-start" alt="aboutus" style="margin:auto;object-fit:cover;text-align:center;height:850px;width:550px;">
            </div>
          </td>
        </tr>
      </table>
    </div>
    <hr>
    <div style="padding: 0 200px 0 200px;">
      <div class="contactLayout1">
        <div class="contactTitle">Get in touch</div>
        <p class="contactDetail1">Want to get in touch? We'd love to hear from you.<br>
          We're ready to serve you at anytime. Feel free to reach us ~
        </p>
      </div>
      <table class="contactLayout1">
        <tr>
          <td>
            <div class="contactSubTitle">Hotline</div>
            <div class="contactDetail2">☏ &nbsp <a href="tel:+043904782" class="contactDetail2">+043904782</a></div>
            <br>
            <div class="contactSubTitle">Support</div>
            <div class="contactDetail2">✉ &nbsp <a href="mailto:support@goodfood.com" class="contactDetail2">support@goodfood.com</a></div>
            <br>
            <div class="contactSubTitle">Address</div>
            <div class="contactDetail2">📍 &nbsp <a href="https://www.google.com/maps/place/Good+Food,+Inc./@40.0973756,-75.9202958,17z/data=
                    !4m13!1m7!3m6!1s0x89c6681e883c3033:0x17a57674dc8744cf!2s4960+Horseshoe+Pike,+Honey+Brook,+PA+19344,+USA!3b1!8m2!3d40.0973756!4d-75.
                    9181071!3m4!1s0x0:0x415c83f07cce1a8a!8m2!3d40.0977834!4d-75.9177898" target="_blank" class="contactDetail2">4960 Horseshoe Pike, Honey Brook,
                <br>&nbsp &nbsp &nbsp PA 19344, United States</a></div>
            <br><br>
    </div>
    </td>
    <td>
      <div class="contactLayout1">
        <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3052.015130247403!2d-75.9202958!3d40.0973756!3m2!1i1024
                  !2i768!4f13.1!3m3!1m2!1s0x0%3A0x415c83f07cce1a8a!2sGood%20Food%2C%20Inc.!5e0!3m2!1sen!2smy!4v1669686121330!5m2!1sen!2smy" width="650" height="500" style="border:0; padding-top:50px;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
        <br><br><br>
      </div>
    </td>
    </tr>
    </table>
    </div>
  </main>

  <?php include "./footer.php" ?>

  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="
    sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
</body>

</html>