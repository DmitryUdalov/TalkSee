#!/usr/bin/python

# USAGE 
# DirectoryServer [port]

import sys
import SocketServer
import thread
import time
import subprocess

# a test user
# username number status
testuser = "Ashley 578-245-1234 busy"
testuser2 = "Chris 234-123-1234 available"
testuser3 = "Mark 234-123-1234 busy"
testuser4 = "Paul 234-123-1234 busy"
testuser5 = "Steve 234-123-1234 available"

# this is run each time the server gets a TCP packet
class MyTCPHandler(SocketServer.StreamRequestHandler):

    def handle(self):
        self.data = self.rfile.readline().strip()
        #print "%s wrote: " % self.client_address[0]
        print self.data
        if(self.data[:6] == "REMOVE" and self.data[:7] != "REFRESH"):
            removeUser(self.data[7:])
        elif(self.data[:3] == "ADD"):
            addUser(self.data[4:])
        #print "SENDING"
        ipuserlist.sort()
        print ipuserlist
        self.wfile.write(ipuserlist)

# add a user
def addUser(toAdd):
    print toAdd
    if (toAdd) not in ipuserlist and not toAdd=="":
        ipuserlist.append(toAdd)

# remove a user
def removeUser(toRemove):
    print toRemove
    if toRemove in ipuserlist and not toRemove=="":
        ipuserlist.remove(toRemove)

def main():
    if(len(sys.argv) == 2):
        port = int(sys.argv[1])
    else:
        port = 3459
    print port
    try:
        HOST, PORT = "lore.cs.purdue.edu", port
        server = SocketServer.TCPServer((HOST, PORT), MyTCPHandler)
        server.serve_forever()
    except KeyboardInterrupt:
        server.socket.close()

# print out the directory list periodically
def server_print():
    pass
    #while(1):
    #    time.sleep(5)
    #    print "----------"
    #    for user in ipuserlist:
    #      print user
    #    print "----------"

ipuserlist = []
#try:
#    thread.start_new_thread(server_print, ())
#except:
#    print "Error: unable to start thread"

# start the server
# add testuser
addUser(testuser)
addUser(testuser2)
addUser(testuser3)
addUser(testuser4)
addUser(testuser5)
main()

