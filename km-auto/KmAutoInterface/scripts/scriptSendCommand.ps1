$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
        $headers.Add("Content-Type", "application/json")
        $headers.Add("X-UIPATH-TenantName", "DefaultTenant")
        $headers.Add("X-UIPATH-OrganizationUnitId", "3104132")
        $headers.Add("Accept", "application/json")
        $headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6IlJUTkVOMEl5T1RWQk1UZEVRVEEzUlRZNE16UkJPVU00UVRRM016TXlSalUzUmpnMk4wSTBPQSJ9.eyJodHRwczovL3VpcGF0aC9lbWFpbCI6InJvYm90c18yQG91dGxvb2suY29tIiwiaHR0cHM6Ly91aXBhdGgvZW1haWxfdmVyaWZpZWQiOnRydWUsImlzcyI6Imh0dHBzOi8vYWNjb3VudC51aXBhdGguY29tLyIsInN1YiI6ImF1dGgwfDYyMzgyZjUxYzU2MzQzMDA2OWM0ZDg2YiIsImF1ZCI6WyJodHRwczovL29yY2hlc3RyYXRvci5jbG91ZC51aXBhdGguY29tIiwiaHR0cHM6Ly91aXBhdGguZXUuYXV0aDAuY29tL3VzZXJpbmZvIl0sImlhdCI6MTY2MzkxNzU2MiwiZXhwIjoxNjY0MDAzOTYyLCJhenAiOiI4REV2MUFNTlhjelczeTRVMTVMTDNqWWY2MmpLOTNuNSIsInNjb3BlIjoib3BlbmlkIHByb2ZpbGUgZW1haWwgb2ZmbGluZV9hY2Nlc3MifQ.H-S9z1ohf_-D_BS7R1kGIrxUVqWeLug3e2Y_D_9bZXNqzOTGUsYHhvStixkyQhg_H65FLjfDbA69sIfIb9TaFSxIik4fMpnrrdt9HF_CeUd8mbojGABWmZPMBB5ORFcKunJc7KPOW72XIrbShMMeU7ZhRU1smnZemUM-yrTakg1NrzUsXGCUuXGdlgbZQF87KkC4PsYBGOBtJyzHhGcdDRgZZjwdArB-PggmrHwLSzQWb1sGZDkARUHkQ3scVAO2kPHaXYzU3c5w8DW4Gb5t20wlC6hWgeaJIMPkb1zIRNWi9bgqWTrobNXavlFJ0BvP3R_m0oGxvNXtgOu5kttPAA")

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
        $write | Out-File C:\Robots\KmAutoInterface\scripts\outputSendComand.txt