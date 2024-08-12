                                                +-------------------------------+
                                                |            Farmers             |
                                                |  (Mobile App & Web Dashboard)  |
                                                +-------------------------------+
                                                         |              |
                                                         v              v
              +------------------------+       +--------------------+  +-------------------------+
              |    User Authentication |       |    Farm Management |  |   Device Management     |
              |       Process          |       |      Process       |  |       Process           |
              +------------------------+       +--------------------+  +-------------------------+
              | 1.1 Receive Credentials|       | 4.1 Create Farm    |  | 7.1 Register Device     |
              | 1.2 Validate Credential|      | 4.2 Update Farm    |  | 7.2 Update Device       |
              | 1.3 Issue JWT          |       | 4.3 Delete Farm    |  | 7.3 Delete Device       |
              | 1.4 Store Session Data |       | 4.4 Farm Details|  |  | 7.4 Device Details      |
              +-----------+------------+       +----------+---------+  +------------+------------+
                          |                           |                       |
                          v                           v                       v
                 +-------------------+        +--------------------+  +-------------------+
                 | User Data Store   |        | Farm Data Store    |  | Device Data Store |
                 +-------------------+        +--------------------+  +-------------------+
                          |                           |                       |
                          v                           v                       v
              +------------------------+       +--------------------+  +-------------------------+
              |    Data Retrieval      |       |   Control Commands |  |   Alerts & Notifications|
              |       Process          |       |       Process      |  |       Process           |
              +------------------------+       +--------------------+  +-------------------------+
              | 9.1 Request Sensor Data|       | 12.1 Receive Command|  | 15.1 Monitor Sensor Data|
              | 9.2 Fetch Historical Data|     | 12.2 Validate Command| | 15.2 Detect Critical Event|
              | 9.3 Generate Reports   |       | 12.3 Send to MQTT   |  | 15.3 Send Alert          |
              +-----------+------------+       | 12.4 Log Command   |  +------------+------------+
                          |                    +----------+---------+               |
                          v                               |                         v
                +-------------------+           +-------------------+      +-------------------+
                | Sensor Data Store |           | Command Data Store|      | Notification Service|
                +-------------------+           +-------------------+      +-------------------+
