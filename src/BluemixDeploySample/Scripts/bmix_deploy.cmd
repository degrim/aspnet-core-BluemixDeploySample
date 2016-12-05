@echo off
set APP_NAME=%1%(%-%)%%DATE:~4,2%%DATE:~7,2%%DATE:~10,4%-%TIME::=-%
cf push %APP_NAME% -p %2%
