### Example 1: Create a Scaling Plan Personal Schedule
```powershell
New-AzWvdScalingPlanPersonalSchedule -ResourceGroupName rgName `
                                        -ScalingPlanName spName `
                                        -ScalingPlanScheduleName scheduleName `
<<<<<<< HEAD
<<<<<<< HEAD:src/DesktopVirtualization/examples/New-AzWvdScalingPlanPersonalSchedule.md
                                        -daysOfWeek @('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday') `
                                        -rampUpStartTimeHour 6 `
                                        -rampUpStartTimeMinute 30 `
                                        -RampUpAutoStartHost "All" `
                                        -rampUpStartVMOnConnect Enable `
                                        -rampUpActionOnDisconnect None `
                                        -rampUpMinutesToWaitOnDisconnect 10 `
                                        -rampUpActionOnLogoff None `
                                        -rampUpMinutesToWaitOnLogoff 10 `
                                        -peakStartTimeHour 8 `
                                        -peakStartTimeMinute 30 `
                                        -peakStartVMOnConnect Enable `
                                        -peakActionOnDisconnect None `
                                        -peakMinutesToWaitOnDisconnect 10 `
                                        -peakMinutesToWaitOnLogoff 10 `
                                        -RampDownStartTimeHour 16 `
                                        -RampDownStartTimeMinute 0 `
                                        -rampDownStartVMOnConnect Enable `
                                        -rampDownActionOnDisconnect None `
                                        -rampDownMinutesToWaitOnDisconnect 10 `
                                        -rampDownMinutesToWaitOnLogoff 10 `
                                        -rampDownActionOnLogoff None `
                                        -offPeakStartTimeHour 22 `
                                        -offPeakStartTimeMinute 45 `
                                        -offPeakStartVMOnConnect Enable `
                                        -offPeakActionOnDisconnect None `
                                        -offPeakMinutesToWaitOnDisconnect 10 `
                                        -offPeakActionOnLogoff Deallocate `
                                        -offPeakMinutesToWaitOnLogoff 10
=======
=======
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654
                                        -DaysOfWeek @('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday') `
                                        -RampUpStartTimeHour 6 `
                                        -RampUpStartTimeMinute 30 `
                                        -RampUpAutoStartHost "None" `
                                        -RampUpStartVMOnConnect Enable `
                                        -RampUpActionOnDisconnect None `
                                        -RampUpMinutesToWaitOnDisconnect 10 `
                                        -RampUpActionOnLogoff None `
                                        -RampUpMinutesToWaitOnLogoff 10 `
                                        -peakStartTimeHour 8 `
                                        -PeakStartTimeMinute 30 `
                                        -PeakStartVMOnConnect Enable `
                                        -PeakActionOnDisconnect None `
                                        -PeakMinutesToWaitOnDisconnect 10 `
                                        -PeakMinutesToWaitOnLogoff 10 `
                                        -RampDownStartTimeHour 16 `
                                        -RampDownStartTimeMinute 0 `
                                        -RampDownStartVMOnConnect Enable `
                                        -RampDownActionOnDisconnect None `
                                        -RampDownMinutesToWaitOnDisconnect 10 `
                                        -RampDownMinutesToWaitOnLogoff 10 `
                                        -RampDownActionOnLogoff None `
                                        -OffPeakStartTimeHour 22 `
                                        -OffPeakStartTimeMinute 45 `
                                        -OffPeakStartVMOnConnect Enable `
                                        -OffPeakActionOnDisconnect None `
                                        -OffPeakMinutesToWaitOnDisconnect 10 `
                                        -OffPeakActionOnLogoff Deallocate `
                                        -OffPeakMinutesToWaitOnLogoff 10
<<<<<<< HEAD
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654:src/DesktopVirtualization/DesktopVirtualization.Autorest/examples/New-AzWvdScalingPlanPersonalSchedule.md
=======
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654
```

```output
Name
----
scalingplan1/PersonalSchedule1
```

Add a Scaling Plan Personal Schedule to an existing Scaling Plan.