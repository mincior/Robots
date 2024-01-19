$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
        $headers.Add("Content-Type", "application/json")
        $headers.Add("X-UIPATH-TenantName", "DefaultTenant")
        $headers.Add("X-UIPATH-OrganizationUnitId", "3104132")
        $headers.Add("Accept", "application/json")
        $headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6IlJUTkVOMEl5T1RWQk1UZEVRVEEzUlRZNE16UkJPVU00UVRRM016TXlSalUzUmpnMk4wSTBPQSJ9.eyJodHRwczovL3VpcGF0aC9lbWFpbCI6InJvYm90c18yQG91dGxvb2suY29tIiwiaHR0cHM6Ly91aXBhdGgvZW1haWxfdmVyaWZpZWQiOnRydWUsImlzcyI6Imh0dHBzOi8vYWNjb3VudC51aXBhdGguY29tLyIsInN1YiI6ImF1dGgwfDYyMzgyZjUxYzU2MzQzMDA2OWM0ZDg2YiIsImF1ZCI6WyJodHRwczovL29yY2hlc3RyYXRvci5jbG91ZC51aXBhdGguY29tIiwiaHR0cHM6Ly91aXBhdGguZXUuYXV0aDAuY29tL3VzZXJpbmZvIl0sImlhdCI6MTY3Mzk1ODI3MywiZXhwIjoxNjc0MDQ0NjczLCJhenAiOiI4REV2MUFNTlhjelczeTRVMTVMTDNqWWY2MmpLOTNuNSIsInNjb3BlIjoib3BlbmlkIHByb2ZpbGUgZW1haWwgb2ZmbGluZV9hY2Nlc3MifQ.hLzZbXvg-96QhQJinvEeFahiRHnBBwMGrbJqEPpKKwNcr4cSb3RFXs9LJhnVIRHG9YeLbxncLlA5Jg6rWDT1sAA5jEbOrSwGQGrmhYXD3ETDapFRWcdZVU9omEyodDSaLJWD4R-LYniHVHst_9ajV7JyQqKz98STSpvMJGm04cxcELpWDEY0sLOOLltZVvwdF1aexcMJzThBOhXO5H4lflYGa43JJIrDdmUR2oWnFySgMIhVeIiVr_0nLsuMJVOCSDegaakip8JYpvBjOGUTuGmwy0ceqtiN3xXpqqXKm_VP89IhTTRls28nu6141IOmTevwwZ1mMOLn3YMXefPUiQ")

        $body = "{
        `n    `"startInfo`":{
        `n        `"ReleaseKey`":`"1d3891b1-3bce-47a8-815f-c5b5a5884199`",
        `n        `"Strategy`":`"ModernJobsCount`",
        `n        `"JobsCount`": 1,
        `n        `"Source`": `"Manual`",
        `n        `"JobPriority`": `"Normal`",
        `n        `"RuntimeType`": `"Unattended`"    
        `n    }
        `n}
        `n"

        $response = Invoke-RestMethod 'https://cloud.uipath.com/uipathrobots/DefaultTenant/odata/jobs/UiPath.Server.Configuration.OData.StartJobs' -Method 'POST' -Headers $headers -Body $body
        $response | ConvertTo-Json
        $write = $response | ConvertTo-Json
        $write | Out-File C:\Consolight_RPA\Robots\km-auto\scripts\outputSendComand.txt