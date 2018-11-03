from html.parser import HTMLParser
import re

class MyHTMLParser(HTMLParser):
    def handle_startendtag(self, tag, attr): 
        print(tag)
        if attr is not None:
            for at in attr:
                print('-> {} > {}'.format(at[0],at[1]))
                
    def handle_starttag(self, tag, attr):
        print(tag)
        if attr is not None:
            for at in attr:
                print('-> {} > {}'.format(at[0],at[1]))


def main():
    MyParser = MyHTMLParser()
    text = str()
    for _ in range(int(input().strip())):
        text += input()
    MyParser.feed(text)
    
    
if __name__ == "__main__":
    main()

