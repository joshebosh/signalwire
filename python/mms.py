#!/usr/bin/python3

from signalwire.rest import Client as signalwire_client

client = signalwire_client("YOU_PROJECT_ID", "YOU_PROJECT_ID", signalwire_space_url = 'joshebosh.signalwire.com')

message = client.messages.create(
from_='+1XXXYYYZZZZ',
body='this is a test',
to='+1XXXYYYZZZZ',
media_url=['http://1co.joshebosh.com/pics/josheboshGIF.gif']
)

print(message.sid)
