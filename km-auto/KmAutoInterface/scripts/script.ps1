$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
        $headers.Add("Accept", "application/json")
        $headers.Add("Content-Type", "application/json")
        $headers.Add("X-UIPATH-TenantName", "DefaultTenant")
        $headers.Add("Authorization", "Bearer 2AUSWcRsUVKMQu9JshNRLVT1YQDjDpMi9M6s40vq")
        $headers.Add("Cookie", "__cf_bm=n6XTJFtEp4gfY2jOjhw25Z_Md2BhdRLM1jU4qhebCGQ-1662364053-0-AdSyasgplagjjWYj8rMZpFnIPsciyImIH4MkCS7UR135BZNTlZRSU6SGD3Nk8Tdkklc2rEaCR5qOQIhN4Jc6q1o=; did=s%3Av0%3Acb651640-2aaa-11ed-bc38-f9a3399d19ef.9fV2kd8BlhIpBOxZEDkatIAzvc1jFxhLGUASpPjuL8o; did_compat=s%3Av0%3Acb651640-2aaa-11ed-bc38-f9a3399d19ef.9fV2kd8BlhIpBOxZEDkatIAzvc1jFxhLGUASpPjuL8o")

        $body = "{
        `n    `"grant_type`":`"refresh_token`",
        `n`"client_id`":`"8DEv1AMNXczW3y4U15LL3jYf62jK93n5`",
        `n`"refresh_token`":`"lSjKVd06HhqjHRBlTlOv7h-_2bf17hCOQc-8oAS1dxiJx`"
        `n}"

        $response = Invoke-RestMethod 'https://account.uipath.com/oauth/token' -Method 'POST' -Headers $headers -Body $body
        $write = $response | ConvertTo-Json
        $write | Out-File C:\Robots\KmAutoInterface\scripts\output.txt