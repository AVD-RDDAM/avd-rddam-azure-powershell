<<<<<<< HEAD
<<<<<<< HEAD:src/DesktopVirtualization/examples/Update-AzWvdScalingPlanPersonalSchedule.md
### Example 1: Update a ScalingPlanPooledSchedule
```powershell
Update-AzWvdScalingPlanPooledSchedule -ResourceGroupName rgName `
                                        -ScalingPlanName spName `
                                        -ScalingPlanScheduleName scheduleName `
                                        -daysOfWeek @('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday') `
                                        -rampUpStartTimeHour 6 `
                                        -rampUpStartTimeMinute 30 `
                                        -rampUpLoadBalancingAlgorithm BreadthFirst `
                                        -rampUpMinimumHostsPct 20 `
                                        -rampUpCapacityThresholdPct 20 `
                                        -peakStartTimeHour 8 `
                                        -peakStartTimeMinute 30 `
                                        -peakLoadBalancingAlgorithm DepthFirst `
                                        -RampDownStartTimeHour 16 `
                                        -RampDownStartTimeMinute 0 `
                                        -rampDownLoadBalancingAlgorithm BreadthFirst `
                                        -rampDownMinimumHostsPct 20 `
                                        -rampDownCapacityThresholdPct 20 `
                                        -rampDownForceLogoffUser:$true `
                                        -rampDownWaitTimeMinute 30 `
                                        -rampDownNotificationMessage "Log out now, please." `
                                        -rampDownStopHostsWhen ZeroSessions `
                                        -offPeakStartTimeHour 22 `
                                        -offPeakStartTimeMinute 45 `
                                        -offPeakLoadBalancingAlgorithm DepthFirst
=======
=======
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654
### Example 1: Update a ScalingPlanPersonalSchedule
```powershell
Update-AzWvdScalingPlanPersonalSchedule -ResourceGroupName rgName `
                                        -ScalingPlanName spName `
                                        -ScalingPlanScheduleName scheduleName `
                                        -DaysOfWeek @('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday') `
                                        -RampUpStartTimeHour 6 `
                                        -RampUpStartTimeMinute 30 `
                                        -RampUpAutoStartHost All `
                                        -RampUpStartVMOnConnect Enable `
                                        -RampUpActionOnDisconnect None `
                                        -RampUpMinutesToWaitOnDisconnect 10 `
                                        -RampUpActionOnLogoff None `
                                        -RampUpMinutesToWaitOnLogoff 10 `
                                        -PeakStartTimeHour 8 `
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
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654:src/DesktopVirtualization/DesktopVirtualization.Autorest/examples/Update-AzWvdScalingPlanPersonalSchedule.md
=======
>>>>>>> 7d31aeaa706c1b5ed7c3c3037cfdab6040ceb654
```

```output
Name
----
spName/scheduleName
```

Updates an existing PersonalSchedule in a Scaling Plan.