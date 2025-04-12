---
sidebar_position: 2
---

# Command Lines

This document provides a quick reference guide for common Linux commands, useful for system administration, file management, text processing, and more.

## System Information & Login Commands

| Command          | Description                    | Common Options                                                                      | Example                                                             |
| ---------------- | ------------------------------ | ----------------------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `uname`          | Show system information        | `-a` - All system info                                                              | `uname -a`                                                          |
| `whoami`         | Display current user           | -                                                                                   | `whoami`                                                            |
| `who`            | Show who is logged in          | `-a` - Show all information                                                         | `who -a`                                                            |
| `last`           | Show last logged in users      | `-n <num>` - Limit number of lines                                                  | `last -n 5`                                                         |
| `ssh`            | Secure Shell connection        | `-p <port>` - Specify port<br/>`-L <local>:<remote>:<host>` - Port forwarding       | `ssh -p 2222 user@hostname`                                         |
| `sudo <command>` | Execute a command as superuser | `-u <user>` - Run as specific user<br/>`-i` - Interactive shell as root             | `sudo -iu {userId}`                                                 |
| `ip`             | Show/manipulate network        | `addr` - Show addresses<br/>`link` - Network interfaces<br/>`route` - Routing table | `ip addr show`<br/>`ip link set eth0 up`<br/>`ip route get 8.8.8.8` |

## Command Help

| Command        | Description           | Common Options                                             | Example                                          |
| -------------- | --------------------- | ---------------------------------------------------------- | ------------------------------------------------ |
| `man {cmd}`    | Show cmd manual pages | `-k` - Search by keyword<br/>`-f` - Show brief description | `man ls`<br/>`man -k search`                     |
| `{cmd} --help` | Quick command help    | `--help` - Show help<br/>`-h` - Short help                 | `docker --help`                                  |
| `apropos`      | Search manual pages   | `-s` - Search in section<br/>                              | `apropos "list files"`<br/>`apropos -s 1,8 file` |
| `whatis`       | Show one-line manual  | `-l` - Long format<br/>`-r` - Regex search                 | `whatis ls`                                      |
| `type`         | Show command type     | `-a` - Show all locations<br/>`-t` - Show type only        | `type cd`                                        |
| `which`        | Show command path     | `-a` - Show all matches                                    | `which python`                                   |

## File Navigation Commands

| Command | Description                     | Common Options                                                                                                                                                         | Example                                          |
| ------- | ------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------ |
| `pwd`   | Print current working directory | -                                                                                                                                                                      | `pwd`                                            |
| `ls`    | List directory contents         | `-l` - Long format<br/>`-a` - Show hidden<br/>`-h` - Human readable                                                                                                    | `ls -la`                                         |
| `cd`    | Change directory                | `.` - Current directory <br/> `..` - Parent directory <br/> `-` - Previous directory <br/> `/` Root directory <br/> `~` = `/home/{you}` <br/> `~user` = `/home/{user}` | `cd /home/user` <br /> `cd ~/` <br/> `cd ~john/` |
| `find`  | Search for files                | `-name` - Search by name<br/>`-type` - File type<br/>`-mtime` - Modified time                                                                                          | `find . -name "*.txt"`                           |

## File Operations

### Basic File Operations

| Command | Description                                                                              | Common Options                                                                                     | Example                                         |
| ------- | ---------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | ----------------------------------------------- |
| `cp`    | Create copy of files/directories<br/>Creates new if dir not exist, overwrites if it does | `-r` - Recursive copy<br/>`-p` - Preserve attributes<br/>`-i` - Interactive<br/>`-u` - Update only | `cp file.txt backup.txt`<br/>`cp -r src/ dest/` |
| `mv`    | Move/rename files and directories                                                        | `-i` - Interactive<br/>`-f` - Force<br/>`-v` - Verbose<br/>`-u` - Update only                      | `mv old.txt new.txt`<br/>`mv file.txt ../dir/`  |
| `rm`    | Remove files/directories                                                                 | `-r` - Recursive<br/>`-f` - Force<br/>`-i` - Interactive                                           | `rm -rf dir/`                                   |
| `ln`    | Create links between files                                                               | `-s` - Soft link<br/>`-f` - Force<br/>`-r` - Relative link                                         | `ln -s target link_name`                        |

### File Permissions

| Command | Description                    | Common Options                                                                                       | Example                                      |
| ------- | ------------------------------ | ---------------------------------------------------------------------------------------------------- | -------------------------------------------- |
| `chmod` | Change permissions             | `+x` - Add execute<br/>`-w` - Remove write<br/>`-R` - Recursive<br/>`644` - Set specific permissions | `chmod +x script.sh`<br/>`chmod -R 755 dir/` |
| `chown` | Change file owner and group    | `-R` - Recursive<br/>`-v` - Verbose<br/>`user:group` - Set both                                      | `chown user:group file`                      |
| `stat`  | Display file/filesystem status | `-f` - Filesystem info<br/>`-t` - Terse output<br/>`--format` - Custom format                        | `stat file.txt`                              |

### File Viewing

| Command | Description            | Common Options                                                                       | Example               |
| ------- | ---------------------- | ------------------------------------------------------------------------------------ | --------------------- |
| `cat`   | Display file contents  | `-n` - Line numbers<br/>`-A` - Show all characters<br/>`-b` - Number non-blank lines | `cat -n file.txt`     |
| `more`  | View file page by page | `-d` - Show commands<br/>`-s` - Squeeze blanks<br/>`+<num>` - Start at line          | `more file.txt`       |
| `less`  | Advanced file viewer   | `-N` - Line numbers<br/>`-S` - Chop long lines<br/>`-i` - Case-insensitive search    | `less -N file.txt`    |
| `head`  | Show first lines       | `-n` - Number of lines<br/>`-c` - Number of bytes                                    | `head -n 10 file.txt` |
| `tail`  | Show last lines        | `-n` - Number of lines<br/>`-f` - Follow file<br/>`-F` - Follow and retry            | `tail -f log.txt`     |

### File Searching & Text Processing

| Command | Description                | Common Options                                                        | Example                        |
| ------- | -------------------------- | --------------------------------------------------------------------- | ------------------------------ |
| `grep`  | Search for patterns        | `-i` - Case insensitive<br/>`-r` - Recursive<br/>`-v` - Inverse match | `grep -i "error" log.txt`      |
| `sort`  | Sort lines of text         | `-n` - Numeric sort<br/>`-r` - Reverse<br/>`-k` - Sort by field       | `sort -n numbers.txt`          |
| `uniq`  | Report/omit repeated lines | `-c` - Count occurrences<br/>`-d` - Only duplicates<br/>`-u` - Unique | `sort file.txt \| uniq -c`     |
| `wc`    | Count lines/words/bytes    | `-l` - Lines only<br/>`-w` - Words only<br/>`-c` - Bytes              | `wc -l file.txt`               |
| `tar`   | Archive files/directories  | `-c` - Create<br/>`-x` - Extract<br/>`-z` - Gzip<br/>`-f` - Filename  | `tar -czf archive.tar.gz dir/` |

## System Resource Management

| Command   | Description           | Common Options                                                                         | Example                                    |
| --------- | --------------------- | -------------------------------------------------------------------------------------- | ------------------------------------------ |
| `top`     | Show processes        | `-u` - User processes<br/>`-b` - Batch mode<br/>`-H` - Show threads                    | `top -u username`                          |
| `ps`      | Process status        | `aux` - All processes<br/>`-ef` - Full format<br/>`-u` - User processes                | `ps aux`<br/>`ps -ef \| grep nginx`        |
| `kill`    | Terminate process     | `-9` - Force kill<br/>`-15` - Graceful stop<br/>`-l` - List signals                    | `kill -9 1234`<br/>`kill -15 5678`         |
| `killall` | Kill by name          | `-i` - Interactive<br/>`-9` - Force kill<br/>`-u` - User's processes                   | `killall -9 firefox`<br/>`killall -u john` |
| `df`      | Disk space usage      | `-h` - Human readable<br/>`-T` - Show filesystem type                                  | `df -h`                                    |
| `du`      | Directory space usage | `-h` - Human readable<br/>`-s` - Summary only<br/>`--max-depth=N` - Show N levels deep | `du -sh *`<br/>`du -h --max-depth=1 /home` |
| `free`    | Memory usage          | `-h` - Human readable<br/>`-s` - Continuous updates                                    | `free -h`                                  |

## User & Group Management

| Command    | Description         | Common Options                                                             | Example                                                   |
| ---------- | ------------------- | -------------------------------------------------------------------------- | --------------------------------------------------------- |
| `useradd`  | Create new user     | `-m` - Create home directory<br/>`-s` - Set shell<br/>`-G` - Add to groups | `useradd -m john`<br/>`useradd -m -s /bin/bash john`      |
| `usermod`  | Modify user         | `-aG` - Add to groups<br/>`-L` - Lock account<br/>`-s` - Change shell      | `usermod -aG docker user`<br/>`usermod -s /bin/bash user` |
| `userdel`  | Delete user         | `-r` - Remove home directory<br/>`-f` - Force removal                      | `userdel -r username`                                     |
| `passwd`   | Change password     | `-l` - Lock account<br/>`-u` - Unlock account<br/>`-d` - Delete password   | `passwd username`<br/>`passwd -l username`                |
| `groupadd` | Create new group    | `-f` - Force create<br/>`-g` - Set GID                                     | `groupadd developers`                                     |
| `groupmod` | Modify group        | `-n` - New name<br/>`-g` - Change GID                                      | `groupmod -n newname oldname`                             |
| `groupdel` | Delete group        | -                                                                          | `groupdel groupname`                                      |
| `groups`   | Show user groups    | -                                                                          | `groups username`                                         |
| `finger`   | Show user info      | `-l` - Long format<br/>`-s` - Short format                                 | `finger username`<br/>`finger -l username`                |
| `id`       | Show user/group IDs | `-u` - User ID<br/>`-g` - Primary group ID<br/>`-G` - All group IDs        | `id username`<br/>`id -u username`                        |

## Network Commands

| Command      | Description              | Common Options                                                                                           | Example                                                              |
| ------------ | ------------------------ | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `ifconfig`   | Network interface config | `-a` - Show all interfaces<br/>`up/down` - Enable/disable interface<br/>`promisc` - Set promiscuous mode | `ifconfig eth0 up`<br/>`ifconfig -a`<br/>`ifconfig eth0 192.168.1.2` |
| `ping`       | Test connectivity        | `-c` - Count of packets<br/>`-i` - Interval                                                              | `ping -c 4 google.com`                                               |
| `traceroute` | Show network path        | `-n` - Don't resolve names<br/>`-m` - Max hops<br/>`-p` - Port number                                    | `traceroute google.com`<br/>`traceroute -n 8.8.8.8`                  |
| `netstat`    | Network statistics       | `-tulpn` - TCP/UDP ports<br/>`-r` - Routing table<br/>`-anp` - All connections with PIDs                 | `netstat -tulpn`<br/>`netstat -anp`                                  |
| `curl`       | Transfer data            | `-O` - Save to file<br/>`-L` - Follow redirects<br/>`-k` - Insecure                                      | `curl -O https://url.com/file`                                       |
| `wget`       | Download files           | `-q` - Quiet mode<br/>`-c` - Continue download                                                           | `wget -q https://url.com/file`                                       |

## Package Management (Debian/Ubuntu)

| Command       | Description         | Common Options                                                      | Example                       |
| ------------- | ------------------- | ------------------------------------------------------------------- | ----------------------------- |
| `apt update`  | Update package list | `-y` - Auto confirm<br/>`-q` - Quiet                                | `sudo apt update`             |
| `apt install` | Install package     | `-y` - Auto confirm<br/>`--no-install-recommends` - Minimal install | `sudo apt install -y git`     |
| `apt remove`  | Remove package      | `--purge` - Remove configs<br/>`-y` - Auto confirm                  | `sudo apt remove --purge pkg` |
| `dpkg`        | Package manager     | `-i` - Install package<br/>`-l` - List packages                     | `sudo dpkg -i package.deb`    | 
