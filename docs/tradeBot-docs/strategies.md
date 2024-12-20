---
sidebar_position: 2
---

# Strategies

### Get Custom Strategies

Frqtrade provide some [strategies](https://github.com/freqtrade/freqtrade-strategies/tree/main/user_data/strategies) that can be used as a starting point

### Add Custom Strategy

- The configuration is now available as `user_data/config.json`
- Copy a custom strategy to the directory `user_data/strategies/`
- Add the Strategy' class name to the `docker-compose.yml` file

  - The **SampleStrategy** is run by default.
  - Each bot can only run one strategy at a time.

    ![strategy](img/image5.png)
    ![strategy](img/image6.png)
