var url = "https://pastebin.com/api/api_post.php";

var xhr = new XMLHttpRequest();
xhr.open("POST", url);

xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

xhr.onreadystatechange = function () {
   if (xhr.readyState === 4) {
      console.log(xhr.status);
      console.log(xhr.responseText);
   }};

var data = "api_dev_key=XXXXXXXXXXXXXXXXXXXXX&api_paste_code=import math;print(math.pi)&api_paste_name=GitHub&api_paste_private=0&api_paste_expire_date=1Y&api_option=paste";

xhr.send(data);
