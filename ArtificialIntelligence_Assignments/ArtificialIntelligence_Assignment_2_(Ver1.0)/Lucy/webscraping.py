import requests
from bs4 import BeautifulSoup

def getWeather():
    URL = "https://www.accuweather.com/en/my/bukit-mertajam/229889/weather-forecast/229889"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://www.accuweather.com/en/my/bukit-mertajam/229889/weather-forecast/229889"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    weather = soup.select("span.phrase")[0].text.strip()

    return weather

def getMTemp():
    URL = "https://myplantin.com/plant/3398"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/3398"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    mTemp = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(3) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return mTemp

def getMWater():
    URL = "https://myplantin.com/plant/3398"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/3398"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    mWater = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(1) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return mWater

def getMLight():
    URL = "https://myplantin.com/plant/3398"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/3398"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    mLight = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(2) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return mLight

def getMTips():
    URL = "https://www.thespruce.com/growing-dipladenia-or-mandevilla-in-containers-847910"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://www.thespruce.com/growing-dipladenia-or-mandevilla-in-containers-847910"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    mTips = soup.select("#mntl-sc-block_1-0-10")[0].text.strip()

    return mTips

def getRTemp():
    URL = "https://myplantin.com/plant/1846"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/1846"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    rTemp = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(3) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return rTemp

def getRWater():
    URL = "https://myplantin.com/plant/1846"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/1846"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    rWater = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(1) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return rWater

def getRLight():
    URL = "https://myplantin.com/plant/1846"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/1846"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    rLight = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(2) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return rLight

def getRTips():
    URL = "https://www.gardendesign.com/roses/care.html"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://www.gardendesign.com/roses/care.html"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    rTips = soup.select("#content > p:nth-child(3)")[0].text.strip()

    return rTips

def getCTemp():
    URL = "https://myplantin.com/plant/1111"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/1111"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    cTemp = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(3) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return cTemp

def getCWater():
    URL = "https://myplantin.com/plant/1111"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/1111"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    cWater = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(1) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return cWater

def getCLight():
    URL = "https://myplantin.com/plant/1111"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/1111"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    cLight = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(2) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return cLight

def getCTips():
    URL = "https://thespruce.com/how-to-grow-cauliflower-1403494"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://thespruce.com/how-to-grow-cauliflower-1403494"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    cTips = soup.select("#mntl-sc-block_1-0-11")[0].text.strip()

    return cTips

def getPTemp():
    URL = "https://myplantin.com/plant/185"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/185"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    pTemp = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(3) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return pTemp

def getPWater():
    URL = "https://myplantin.com/plant/185"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/185"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    pWater = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(1) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return pWater

def getPLight():
    URL = "https://myplantin.com/plant/185"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://myplantin.com/plant/185"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    pLight = soup.select("#main > section.flex.plant-section_plantSection__BrSg_ > div > div.plant-section_plantSection__content__fI8Nf > div.plant-section_plantSection__plant__fdskV > div.md\:grid.block.gap-6.grid-cols-11 > div.xl\:col-start-5.xl\:col-end-12.md\:col-start-6.md\:col-end-13.flex-col-reverse > div.md\:overflow-auto.overflow-scroll.no-scrollbar.md\:mr-0.-mr-3 > div > div:nth-child(2) > div > div.whitespace-nowrap > p.text-14.font-semibold")[0].text.strip()

    return pLight

def getPTips():
    URL = "https://housing.com/news/pitcher-plant/#How_to_grow_Pitcher_Plant"

    sess = requests.session()

    headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
    "Referer": "https://housing.com/news/pitcher-plant/#How_to_grow_Pitcher_Plant"
    }

    req = sess.get(URL, headers = headers)

    soup = BeautifulSoup(req.content, "html.parser")

    pTips = soup.select("#post-142143 > div.entry-content > p:nth-child(60)")[0].text.strip()

    return pTips