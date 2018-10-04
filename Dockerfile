FROM microsoft/dotnet:2.1.403-sdk-bionic

RUN apt-get update -y \
	&& apt-get upgrade -y \
	&& apt install software-properties-common -y

# install sqlite3
RUN add-apt-repository ppa:jonathonf/backports
RUN apt-get install -y \
	sqlite3 \
	libsqlite3-dev \
	&& rm -rf /var/lib/apt/lists/*

# TODO: clean
# ..
# ..

RUN mkdir /db
RUN /usr/bin/sqlite3 /db/test.db

CMD /bin/bash
