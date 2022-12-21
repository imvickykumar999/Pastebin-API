
import requests
from requests.structures import CaseInsensitiveDict

url = "https://pastebin.com/api/api_post.php"

headers = CaseInsensitiveDict()
headers["Content-Type"] = "application/x-www-form-urlencoded"

data = '''api_dev_key=XXXXXXXXXXXXXXXXXXXXXXX&api_paste_name=GitHub&api_paste_private=0&api_paste_expire_date=1Y&api_option=paste&api_paste_code=
import math
print(math.pi)
'''

resp = requests.post(url, headers=headers, data=data)

print(resp.text)
