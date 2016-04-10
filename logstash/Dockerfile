FROM logstash:latest

COPY config/logstash.conf /etc/logstash/conf.d/logstash.conf

CMD ["logstash", "-f", "/etc/logstash/conf.d/logstash.conf"]