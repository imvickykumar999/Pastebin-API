URL url = new URL("https://pastebin.com/api/api_post.php");
HttpURLConnection http = (HttpURLConnection)url.openConnection();
http.setRequestMethod("POST");
http.setDoOutput(true);
http.setRequestProperty("Content-Type", "application/x-www-form-urlencoded");

String data = "api_dev_key=XXXXXXXXXXXXXXXXXXXX&api_paste_code=import math;print(math.pi)&api_paste_name=GitHub&api_paste_private=0&api_paste_expire_date=1Y&api_option=paste";

byte[] out = data.getBytes(StandardCharsets.UTF_8);

OutputStream stream = http.getOutputStream();
stream.write(out);

System.out.println(http.getResponseCode() + " " + http.getResponseMessage());
http.disconnect();

