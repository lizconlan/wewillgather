// <auto-generated />
namespace Gather.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class AddFieldNullableCreatedBy : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201205281127176_AddFieldNullableCreatedBy"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so8+zdp7X46dZm32UHpdFRii8zsvz98Rn5yHw+cj2RH2dEk7t9ZvrVc79ffbRV01e+y2oze+VXwcf0Ecv62qV1+31q/xc3zubfZTeDd+7233Rvua9g67pt2V7b++j9MW6LLNJSR+cZ2WTf5SuPn30uq3q/PN8mddZm89eZm2b10u8mzPqSoJHq09vR4WHd3f2QIW72XJZtVlLU9tDvIPmSZ2ja6J+bvDF729oMiMob4b1tGhWZXaNPwys121NjPdR+qx4l8+e58uLdm6BfZG9M5/sE/d9tSyITemdtl4Hfcvfm7s+XWRF+Z6d7u7sfCPd0rCnZdWs6/zmOd8M7hkJxKSq3tLH50X5vkT8BsbzPGva59VFsfxG+OFNXuarebV834Hc+9Bh2I6/ual5c1VAOH/OZua7+aQp3JzcsuN731S/3xwhj6dtcWnH8aSqyjxbvjeUpzTDpLbeG8yL7LK4YMXYAQjT8IqANB+lr/KSWzTzYiWmaIxvf3+vybO6WuBXec998/u/rtb1FKOrol+/yeqLvA2xenzX2akbrRfA/MiChWg2r6+bNuf5eG9+6MD6GqZr7/79DSJ2q14F/5+bvv9fKo4v83pRNPBNX+XTqp7FxbLbKi6iw62sPBpx3dDUSPbXEt0u3B+J8IeKHf36oaz/QxW7r2l4PpjDuwbpFsLwtTj8hHjnoqqvf8TZsfDqyfWHOU3fZJQGH5+i8uK8+HC8fFjfCHJfQxp3P9jH/Tm0gbeWr5fZxY8cv45QVMuWOntPdtlsOG7DLjfL9HtA+UakxrjAzCTvxX//H1MPX+Rt9jRvpnWxEg55r6nfvf+hmgL9k/RciUf6Xp3f/2A1hc7fFG35w1eQPze9/n9BLT+vpqKr/t+gmv9fpJq/QeX27ayZv8ku3pP99j6U+26pB98X1E0kuQ28n29OUrohfDqZF+XMSGE8hjLf/v4vs5okwIqsF0ANNOnlB4baxZIDm7DuYvLNYt2N+W4a3a2xrpoWDHQTmV2zGK7m2w1o2iYfFJIaMD/SzR23efbe2uP+ByqPb9Ie/L9YMf9c68gBub2lnrml2A7rxJ5kfy2xfb2eTvOmgaD8KJv0vpHnrSTo50Aa3xvWN4Lcz03c8npe1e3r9WKR1ZYgt+x8/4M7P67bYvreg/7wpAj9+dP5tL1ZkP7fGuP+nIf2P5d5jf+XGq7jdUuyFDVbvpX4/U07Z7ciX/f8zVibD3I4X+dti/n6kdHy0cS/78vQGwXqVrz4k1m5ft9uaXzv2e8Qaxw3TTUtmDxGPw4v5IXjOF3O0huX6iwry/BiK4U0snXZFquymBKCn330rR7FbtWT9fZcT+bLG3p4fNejwmbiAOItCBI2ixEBX77PwDsQfyiDHQrsh3C8Mcp3yDpH//YkuDH1cTP4nfF49xsgh40/bka1n0O4GcvdEC5B/nL5lC1WCvNXLbGI3UyzWV+3kJTP3gOpCOlsLuIbY6OYARzCcaM1dEgGkdd7sNAmQ3qDcH5zkzJIOtHQWCzMCjKDSr7Ps3ae119O4LTyQuK7tkc+vEc23VNS5Bk6hR8Mq0ec/sui3OIARMXcAKSrpjvABszADUBPyC+4qOoiipp+eX0jFKw8RtHhFckbXjYiFAPgpPkmDFz6oo+Flb4bgHicHCdIKCI3QRN/MApHXcUuCI+Hh+fdM5Wp98KAIzBkWAMRvoWvYUcXZcRwHLeFbbSEB9sbW1fgQ+LcgnAdvyJCrE2eRzCIAd+jg/hmQgx4Gz9Lgx9cQOhT4VYuyYDVizsl3pg86d5Am5vckNsA/CAiOfWxiT5xH2VgJD0v5TaDuAlWhCAe7h9MkGhc3afIjd5HMIxN/oc3jq723UCYTS7HTTK5gSomnrPegv3u8d3XHBfrB4/vUpNpvmrXWfkFkb5szBdfZKsVlL57Uz9JX6+yKQzu9muNum8Xch/cpah7ITDuTgPO6/o2ticiCxnezrey9POsqJuWMqrZJEM0ezJb9Jq9h29kevRdpP6sGeNnWuN33w0bAx9xpDovO/I9oxEtSDPw4HRodo77r9GLr6dZmdWRpMlJVa4Xy6HEy6a3g8y5Dyb44vbwnhbNqsyuJUXiwwu+uD2800VWlCEk/eg9YVD/07Jq1nXeJVjk69vDfkYSMKmqt/TxeVF2xtz78vZwsXLwvLoolv2Z6Xx1e5hvKAxZzatlB5738deANUzXgSbv0cdVgeRelLTd724P9bv5pCm6NLUfvjec4fFHG9wevslg+yDNZ7eH8tRksANZNB/24Ty+29FOXd3n5Qe1ZccUdTXprfXskMN6e13LMefX07fxV392dO5Z8/q6aXNO7HfgBN/cHmJf3b6vnpV++3D8z28P7Rvj3f8v8G4/dvy6PNxLdbw/L98M4meHp3+uOPDnaM69HNPXnWybiXr/SR5+9WdnctUXfHIddRGf9PJGt4D1jTmc8IYoXinOiz6C3e++HtS4BxZ+e3vIHy4oP7+UK6dhv66McbL2/eUr/trPkmwhHF22HVkwH74HnP8Xy6hxayR3HnN4Yln1dAPE/69J/Rd5mz3Nm2ldrCRl6QPuffl+cH+v/PpKUtZdoO6b94P4pmi7nqn38e1hReC8N4yfV9rO5VC/rsYbynTfQusNv/qzpPm+YS3z7ayZv8kuQlj2w9vD+f+absG/P/Iobi1jm1Y8bidjdvH1/WVs+NWfJRnjNeLQtZi916x+01L6/zXp+nklG531qq8rIP5a1tcQks2v/ywJyv+L3ef/r4nMN+H2vab1z/b1erHI6s6Iw29uD/G4botpFy/74e3h0J9YRuyym/fx7WF9k872z04o8LMRtPz8Uql529JfH6BMBcDX0aNDb/7sqFD8+2F+6E9m5boDQj/64U/ncdNU04IDohsz/r+/W74achk3vHFTCn9oeYo4aNbVTYPd/P6vq3U9jbmst+KEHuAYa4CkFqMPQvZNVl/k7ddF1sB5TyQf343O+e3ZAv3ezArdVrHVyPeY8hDcB04zA3s/qt0Gqf9vTqfJh/z+L7Oa9ItNjwzM62Dz2+ZZInQcgPmBBO0Aez+yvheeH8aN740Ypc1nBTpOz5oX67L87KPzrGw6FuXG0X+DjGNTDTfyjGt525TBxmkw4D5wBn52eMQit5mNgdw3xx4fPKt+VPr7H69bCkOGpjXa9H2i3Aj5IjA/kH4K5P3IeGvcPozx3g+pm+fWeHtYWMuKZV53m1h3Uj+xfzfmA4yO1q8oKM5L8yEPZ54vMh5Gs8qmuWTYnhV104IXJlmTS5OPUsL9spjlNRGMF72UWX5ReVIWOVb7TIMvsmVxnjftm+ptvvzso72dnYOP0uOyyBo49eX5R+m7RbmkP+Ztu3p0927DHTTjRTGtq6Y6b8fTanE3m1V36dWHd3f27uazxd2mmZX+fHgRiGe2wxl7THFjdxrMFLzKz73Z6+rQ7ov2Ne8ddP3ZRwWGztLxeU4zgwzJy6xt83qJVjkj+VEKfZ5Nytzq9E6HHfBBqkX6mdHvbYGI5D1hPS2aVZld4w8Da3mZ1dN5RmL9Rfbueb68aOeffbS/44Nu637g0oV8usiKciPM3Z2drweVkJ6WVbOu8w6l33Pwz4inJ1X1lj4+L8rNBPg6yCLR9Ly6KJbfyFS9ofh/Na+Wm/G8995YWrjfFFnfXBVg8Z8tqn43nzSFo+cAFb4u2G+KCCbpIxAmxftDeGryPbcF4acFbtSF/RDs/7P68KwRm8NDujW1+nBuVIJ79++/N1BB7WcF9P+bWexlJwHy/xNWi83j1iJ7d+e9IX1jfHHrKTkhElz0HPL/z06Ft3z19bX0N+lKdZervj5W/QWqD0TtRjbbfX97+f9q7UPBzP9f2JyiOg6gblA6t5mym0TmPWB8I2xpDDdP16254P9TktdbStwkhPffWwjD5c8NsO+/v4B7K7XfrOb4WQH6/2Z1FM+K/39XJX2DKuDbWTN/k11s9oHemxlupRDeF9BN470NvP+fGOI+iMjKwy2Jfmspii8W/H9SisSwz25ghfvvywnfpGD+v1aE/l/B7jcz+ofYi+Hlk//vcvuPorVbA/xZ8Y9e08JV+3q9WGS1He1Apv+9YR/XbTHto/y1YhT686fzafs+ctUH8rPmuv5s+9s/i6HC/yv0prcue9vZvb3WzNuWFjX/P6Mwv1lP8Vbk/8msXG+GutdZkPmQCXnZyQF/yLJDF1Z8ab//nukz0v5mmxjt9LZ82wcX4HJbMLemNqB/CIXx7g+Fqraj25LgZ5mSx01TTQt257reXRjVdKh6upylQMKL7xWX13l5PnYffrEu22JVFlPq/LOPdsbj3d74+rAA41bwvtUDRvOUA+8iKyl72LR1RsTpT2qxnBarrOyOodMwOv9RNrlrQXa/eZqv8iU8x9gYb9NfJLrsd2976fDjTeR4fNfjgNsyhsaizTfDE7tdKjz+cvmUrW0Ks10tsXrTTLNZXzKIqWdDONiI2cfBffj/eT6KZwS4ab+vn3vu8cO63188oUH2gYYLpk0++KGwTRB++jiEX/yssA8P8zbT+YGsMxxic/N+f57n+nPCPD1fxNjA5vd/Xa3radfme1qguxQfaIPelz8UFht0DTfh5hr9rLBejxS3YYsPZMPbucj86tf1iX+OmfNNVl/k7UY915v4oYn+ecSM78UIP5dMuCEU+CExH8cTt9aGP5eG1YRoUYb/ITDUrSb0A5lpOAzl5u8Td/4cMM//B7TVzzUT3Xpify4Y6YepiSSbQO+09EZeKxZY1ntW1E1LSwHZJGv6mghvUa7Sw/qjVD7taaXX03m+yGgpYVLRVEtmQ77p5Q/6UIUPopDlqyHo8u0NPfQdx15P/SaxHvutbuj5hNZVLjgC6fXovor15L69aWzZRYxy8nF0DPzNDVBd8N+D7L6KQXff3oS3De37uNuvovjbb2/oIYwAe72EX8d6Clvc1Jtm9CMdmW+ifZgv35OFNwjNcNPbsPTvz2rpi2y1ug1aoR6Pyu/NMmxt2mC3nlbr82g385l6rTs8uzFJGliurgBQt8PMHX1TkqK3eDtQ2tTyvYZuc3sbRx3PAH5DA+5KMr85KKXvP9hYKioy2hszVj3PJEA4ZqqCN2LqhN/cqCbef7g3J08ig7/5pQ3zN2AdZR5vsHgbIXU1QxTioBX/RkmnzvL7kS7mYfe4qDfAoQH9v4pUgd7dxFnxht+kYMVsiH3zZ2/IwxwRb/izwQXf9NDNsqF19O13j++K9dUP6E9SV+QJfkE6umz4Uwov1vT2QhYcKcZpigsDgv4mmMucY0EH1LQ5W55XJsjpYGSamK91Mr7I22xGUcdx3Rbn2bSlr6FE2fjzyv9nH50uJvnsbPnlul2tWxpyvpiUgYJFnLSp/8d3ezg//nKFv5pvYgiEZkFDyL9cPlkX5czi/SyynDsAAgHY5zl9LnNJ8Rx5/dcW0otqeUtASr6nJm58ky9WJQFrvly+zi7zYdxupmFIscdPi+yizhY+BeUTY60z6tnrgjrw33D90Z/ErrPFu6P/JwAA//+3VT0VXaIAAA=="; }
        }
    }
}