﻿using Core.Persistence.Repositories;
using Core.Security.Enums;
using Domain.Entities;

namespace Core.Security.Entities;

public class User : Entity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Nick { get; set; }
    public string Photo { get; set; }

    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }
    public int Token { get; set; }
    public bool Pro { get; set; }
    public bool Blocked { get; set; }
 
    public AuthenticatorType AuthenticatorType { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = null!;
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = null!;
    public virtual ICollection<EmailAuthenticator> EmailAuthenticators { get; set; } = null!;
    public virtual ICollection<OtpAuthenticator> OtpAuthenticators { get; set; } = null!;
    public virtual ICollection<Image> Images { get; set; } = null!;

    public User()
    {
        
        Email = string.Empty;
        PasswordHash = Array.Empty<byte>();
        PasswordSalt = Array.Empty<byte>();
        Nick = string.Empty;
        Photo= string.Empty;
    }

    public User(
        string firstName,
        string lastName,
        string email,
        byte[] passwordSalt,
        byte[] passwordHash,
        bool status,
        AuthenticatorType authenticatorType,
        string nick,
        int token,
        bool pro,
        bool blocked,string photo
    )
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Nick = nick;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
        Token = token;
        Pro = pro;
        Blocked = blocked;
        Photo = photo;
    }

    public User(
        int id,
        string firstName,
        string lastName,
        string email,
        byte[] passwordSalt,
        byte[] passwordHash,
        bool status,
        AuthenticatorType authenticatorType,
            string nick,
        int token,
        bool pro,
        bool blocked, string photo
    )
        : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
        Nick = nick;
        Token = token;
        Pro = pro;
        Blocked = blocked;
        Photo = photo;
    }
}
