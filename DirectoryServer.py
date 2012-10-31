#!/usr/bin/python

# USAGE 
# DirectoryServer [port]

import sys
import SocketServer
import thread
import time
import subprocess

# a test user
# UserName Port UserID Status
testuser = "Ashley 1234 4321 busy"

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
        #print ipuserlist
        for user in ipuserlist:
            self.wfile.write(user + "\n")
        #self.wfile.write(ipuserlist)

# add a user
def addUser(toAdd):
    if (toAdd) not in ipuserlist:
        ipuserlist.append(toAdd)

# remove a user
def removeUser(toRemove):
    #print toRemove
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
    while(1):
        time.sleep(5)
        print ipuserlist

ipuserlist = []
try:
    thread.start_new_thread(server_print, ())
except:
    print "Error: unable to start thread"

# start the server
# add testuser
addUser(testuser)
main()

