---
title: "Update conditionalaccesspolicy"
description: "Update the properties of a conditionalAccessPolicy object."
ms.localizationpriority: medium
author: "davidspooner"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Update conditionalaccesspolicy

Namespace: microsoft.graph

Update the properties of a [conditionalAccessPolicy](../resources/conditionalaccesspolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Policy.Read.All, Policy.ReadWrite.ConditionalAccess and Application.Read.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Policy.Read.All, Policy.ReadWrite.ConditionalAccess and Application.Read.All |

> [!NOTE]
> This API has a [known issue](/graph/known-issues##conditional-access-policy) related to permissions.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /identity/conditionalAccess/policies/{id}
```

## Request headers

| Name          | Description      |
|:--------------|:-----------------|
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

For the list of properties, see [conditionalAccessPolicy](../resources/conditionalaccesspolicy.md).

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_conditionalaccesspolicy"
}-->

```http
PATCH https://graph.microsoft.com/v1.0/identity/conditionalAccess/policies/{id}
Content-type: application/json

{
    "conditions": {
        "signInRiskLevels": [
            "high",
            "medium",
            "low",
        ]
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conditionalAccessPolicy = new ConditionalAccessPolicy
{
	Conditions = new ConditionalAccessConditionSet
	{
		SignInRiskLevels = new List<RiskLevel>()
		{
			RiskLevel.High,
			RiskLevel.Medium,
			RiskLevel.Low
		}
	}
};

await graphClient.Identity.ConditionalAccess.Policies["{conditionalAccessPolicy-id}"]
	.Request()
	.UpdateAsync(conditionalAccessPolicy);

```


 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": false
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update conditionalaccesspolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
